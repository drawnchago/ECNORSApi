using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class PemexEnvioArchivo
{
    public int NumeroEstacion { get; set; }

    public int NumeroLote { get; set; }

    public short TipoArchivo { get; set; }

    public short? CodigoPemex { get; set; }

    public string? Archivo { get; set; }

    public string? ArchivoCifrado { get; set; }

    public string? ArchivoCheckSum { get; set; }

    public DateTime FechaHoraCreacion { get; set; }

    public DateTime FechaHoraCifrado { get; set; }

    public DateTime FechaHoraCodigo { get; set; }

    public virtual PemexCodigo? CodigoPemexNavigation { get; set; }

    public virtual PemexTiposArchivo TipoArchivoNavigation { get; set; } = null!;
}
