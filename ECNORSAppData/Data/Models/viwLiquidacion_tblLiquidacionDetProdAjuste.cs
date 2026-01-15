using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viwLiquidacion_tblLiquidacionDetProdAjuste
{
    public long intFolioLiquidacion { get; set; }

    public long intSecuencia { get; set; }

    public int intProducto { get; set; }

    public string? strProducto { get; set; }

    public double? dblExistenciaInicial { get; set; }

    public double? dblEntradas { get; set; }

    public double? dblExistenciaFinal { get; set; }

    public double? dblSalidas { get; set; }

    public double? dblTotalVenta { get; set; }

    public DateTime? datFechaCaptura { get; set; }

    public string? strUsuarioCaptura { get; set; }

    public string? strPCCaptura { get; set; }

    public string? strCapturo { get; set; }
}
