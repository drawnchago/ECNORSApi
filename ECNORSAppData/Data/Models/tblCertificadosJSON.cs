using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblCertificadosJSON
{
    public string? strRFCCertificado { get; set; }

    public string? strNumeroFolioCertificado { get; set; }

    public DateTime? datFechaEmisionCertificado { get; set; }

    public string? strResultadoCertificado { get; set; }
}
