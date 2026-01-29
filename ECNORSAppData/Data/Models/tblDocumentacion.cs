using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECNORSAppData.Data.Models;

[Table("tblDocumentacion")]
public sealed class tblDocumentacion
{
    [Key]
    public long Id { get; set; }

    [Required, MaxLength(260)]
    public string OriginalName { get; set; } = "";

    [Required, MaxLength(120)]
    public string ContentType { get; set; } = "";

    public long SizeBytes { get; set; }

    [Required, MaxLength(200)]
    public string StoredFileName { get; set; } = "";

    [Required, MaxLength(400)]
    public string RelativePath { get; set; } = "";

    public DateTime CreatedAtUtc { get; set; }

}