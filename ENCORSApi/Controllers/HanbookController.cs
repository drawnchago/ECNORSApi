using ECNORSAppData.Data;
using ECNORSAppData.Data.DTO;
using ECNORSAppData.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ENCORSApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class HandbookController : ControllerBase
{
    private readonly IConfiguration _cfg;
    private readonly IWebHostEnvironment _env;
    private readonly ILogger<HandbookController> _log;

    public HandbookController(IConfiguration cfg,IWebHostEnvironment env,ILogger<HandbookController> log)=> (_cfg, _env, _log) = (cfg, env, log);

    private AppDbContext CreateDb()
    {
        var cs = _cfg.GetConnectionString("DefaultConnection");

        var opts = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer(cs)
            .Options;

        return new AppDbContext(opts);
    }

    /*LISTA DOCUMENTOS*/
    [HttpGet]
    public async Task<IActionResult> List(CancellationToken ct)
    {
        _log.LogInformation("HandbookController | List | DefaultConnection");

        try
        {
            await using var db = CreateDb();

            var list = await db.tblDocumentacion
                .AsNoTracking()
                .OrderByDescending(x => x.CreatedAtUtc)
                .Select(x => new HandbookDto(
                    x.Id,
                    x.OriginalName,
                    x.ContentType,
                    x.SizeBytes,
                    x.CreatedAtUtc
                ))
                .ToListAsync(ct);

            return Ok(new
            {
                Message = "Se obtuvo correctamente los registros",
                Data = list
            });
        }
        catch (Exception ex)
        {
            _log.LogError(ex, "HandbookController | List | Error");
            return StatusCode(500, new { Message = "Error al obtener documentos" });
        }
    }

    [HttpPost("upload")]
    [Consumes("multipart/form-data")]
    [RequestSizeLimit(50_000_000)]
    public async Task<IActionResult> Upload([FromForm] HandbookUpload form, CancellationToken ct)
    {
        _log.LogInformation("HandbookController | Upload | File={Name}", form?.File?.FileName);

        if (form?.File is null || form.File.Length == 0 || form.Folder is null) return BadRequest(new { Success = false, Message = "Archivo y carpeta requerida" });

        try
        {
            var file = form.File;

            var ext = Path.GetExtension(file.FileName);
            var storedName = $"{Guid.NewGuid():N}{ext}";

            var relPath = Path.Combine("Storage", form.Folder, DateTime.UtcNow.ToString("yyyy"), DateTime.UtcNow.ToString("MM"), DateTime.UtcNow.ToString("DD")).Replace("\\", "/");
            var physicalDir = Path.Combine(_env.ContentRootPath, relPath);Directory.CreateDirectory(physicalDir);
            var physicalPath = Path.Combine(physicalDir, storedName);

            await using (var fs = System.IO.File.Create(physicalPath)) await file.CopyToAsync(fs, ct);
            await using var db = CreateDb();

            var row = new tblDocumentacion
            {
                OriginalName = file.FileName,
                ContentType = file.ContentType ?? "application/octet-stream",
                SizeBytes = file.Length,
                StoredFileName = storedName,
                RelativePath = relPath,
                CreatedAtUtc = DateTime.UtcNow
            };

            db.tblDocumentacion.Add(row);
            await db.SaveChangesAsync(ct);

            return Ok(new { Success = true, Data = new { row.Id, row.OriginalName } });
        }
        catch (Exception ex)
        {
            _log.LogError(ex, "HandbookController | Upload | Error");
            return StatusCode(500, new { Success = false, Message = "Error al subir archivo" });
        }
    }

    /*DESCARGA DOCUMENTO*/
    [HttpGet("{id:long}/download")]
    public async Task<IActionResult> Download(long id, CancellationToken ct)
    {
        _log.LogInformation("HandbookController | Download | Id={Id}", id);

        try
        {
            await using var db = CreateDb();

            var doc = await db.tblDocumentacion
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id, ct);

            if (doc is null)
                return NotFound(new { Success = false, Message = "Documento no encontrado" });

            var physicalPath = Path.Combine(
                _env.ContentRootPath,
                doc.RelativePath.Replace("/", Path.DirectorySeparatorChar.ToString()),
                doc.StoredFileName);

            if (!System.IO.File.Exists(physicalPath))
                return NotFound(new { Success = false, Message = "Archivo no existe en disco" });

            return PhysicalFile(physicalPath, doc.ContentType, doc.OriginalName);
        }
        catch (Exception ex)
        {
            _log.LogError(ex, "HandbookController | Download | Error");
            return StatusCode(500, new { Success = false, Message = "Error al descargar archivo" });
        }
    }
    /*VISUALIZA DOCUMENTO (INLINE EN NAVEGADOR)*/
    [HttpGet("{id:long}/view")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> View(long id, CancellationToken ct)
    {
        _log.LogInformation("HandbookController | View | Id={Id}", id);

        try
        {
            await using var db = CreateDb();

            var doc = await db.tblDocumentacion
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id, ct);

            if (doc is null)
                return NotFound(new { Success = false, Message = "Documento no encontrado" });

            var physicalPath = Path.Combine(
                _env.ContentRootPath,
                doc.RelativePath.Replace("/", Path.DirectorySeparatorChar.ToString()),
                doc.StoredFileName);

            if (!System.IO.File.Exists(physicalPath))
                return NotFound(new { Success = false, Message = "Archivo no existe en disco" });

            // Forzar "inline" para que el navegador intente visualizarlo
            Response.Headers.ContentDisposition =
                $"inline; filename=\"{Uri.EscapeDataString(doc.OriginalName)}\"";

            return PhysicalFile(physicalPath, doc.ContentType);
        }
        catch (Exception ex)
        {
            _log.LogError(ex, "HandbookController | View | Error");
            return StatusCode(500, new { Success = false, Message = "Error al visualizar archivo" });
        }
    }

}
