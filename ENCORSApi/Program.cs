using ECNORSApi.Config;
using ECNORSApi.Factories;
using ECNORSAppData.Data.Config;
using ECNORSAppData.Services;
using Serilog;
using Microsoft.Extensions.FileProviders;


var builder = WebApplication.CreateBuilder(args);

// ================= SERVICES =================
//Log
builder.Host.UseSerilog((ctx, lc) =>
{
    lc.ReadFrom.Configuration(ctx.Configuration)
      .WriteTo.Console()
      .WriteTo.File("Logs/api-.log", rollingInterval: RollingInterval.Day,
      retainedFileCountLimit: 5);
});

// Controllers
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuración de estaciones desde appsettings.json
builder.Services.Configure<StationsOptions>(builder.Configuration);

// Factory para DbContext por estación
builder.Services.AddSingleton<IStationDbFactory, StationDbFactory>();
builder.Services.AddSingleton<IConnectionSelector, ConnectionSelector>();
builder.Services.AddScoped<SelectedConnectionState>();
builder.Services.AddScoped<ICloseLoadService, CloseLoadService>();
builder.Services.AddCors(opt =>
{
    opt.AddDefaultPolicy(p =>
        p.AllowAnyOrigin()
         .AllowAnyHeader()
         .AllowAnyMethod());
});

var app = builder.Build();

app.UseCors();

var webRoot = Path.Combine(app.Environment.ContentRootPath, "wwwroot");

app.UseStaticFiles();

// ================= MIDDLEWARE =================

// Swagger SIEMPRE habilitado (útil para IIS y pruebas)
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("v1/swagger.json", "ECNORSA API v1");
    c.RoutePrefix = "swagger"; // https://host/swagger

    c.DocumentTitle = "ECNORSA API´s";

    c.HeadContent = @"<link rel='icon' type='image/x-icon' href='/assets/orsan.ico' /><script src='/assets/swagger-logo.js'></script>";
});

app.Use(async (ctx, next) =>
{
    var station = ctx.Request.Query["station"].ToString();
    if (string.IsNullOrWhiteSpace(station))
        station = ctx.Request.Headers["X-Station"].ToString();

    var state = ctx.RequestServices.GetRequiredService<SelectedConnectionState>();
    state.SetSelectedName(station);

    await next();
});


//app.UseHttpsRedirection();


app.UseAuthorization();

app.MapControllers();

app.Run();
