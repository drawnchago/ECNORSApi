using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class AUX_tblLikuitiEnc
{
    public long intFolioCorte { get; set; }

    public int intTurno { get; set; }

    public int intIsla { get; set; }

    public int? intUsuario { get; set; }

    public string? strNombreUsuario { get; set; }

    public string strDespachadores { get; set; } = null!;

    public double? dblImporteProductos { get; set; }

    public double? dblImportePagos { get; set; }

    public double? dblImporteTotal { get; set; }

    public DateTime? datFechaLiquidacion { get; set; }

    public string? strUsuarioCaptura { get; set; }

    public string? datFechaCaptura { get; set; }

    public string? strPCCaptura { get; set; }
}
