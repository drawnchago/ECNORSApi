using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblLiquidacionEnc
{
    public long intFolioLiquidacion { get; set; }

    public long intFolioCorte { get; set; }

    public int intTurno { get; set; }

    public int intIsla { get; set; }

    public int intUsuario { get; set; }

    public string strNombreUsuario { get; set; } = null!;

    public string strDespachadores { get; set; } = null!;

    public double dblImporteProductos { get; set; }

    public double dblImportePagos { get; set; }

    public double dblSobrante { get; set; }

    public double dblFaltante { get; set; }

    public DateTime datFechaLiquidacion { get; set; }

    public string? strUsuarioCaptura { get; set; }

    public string? datFechaCaptura { get; set; }

    public string? strPCCaptura { get; set; }

    public virtual tblFoliosCorte intFolioCorteNavigation { get; set; } = null!;
}
