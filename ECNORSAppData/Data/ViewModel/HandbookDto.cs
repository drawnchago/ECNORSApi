using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ECNORSAppData.Data.DTO;

public sealed record HandbookDto(
    long Id,
    string OriginalName,
    string ContentType,
    long SizeBytes,
    DateTime CreatedAtUtc
);
public sealed class HandbookUpload
{
    [Required]
    public IFormFile File { get; set; } = default!;
    [Required]
    public string? Folder { get; set; }
}