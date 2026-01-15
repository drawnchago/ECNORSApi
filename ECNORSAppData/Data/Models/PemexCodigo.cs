using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class PemexCodigo
{
    public short CodigoPemex { get; set; }

    public string? DescripcionCorta { get; set; }

    public string? DescripcionLarga { get; set; }

    public virtual ICollection<PemexEnvioArchivo> PemexEnvioArchivos { get; set; } = new List<PemexEnvioArchivo>();
}
