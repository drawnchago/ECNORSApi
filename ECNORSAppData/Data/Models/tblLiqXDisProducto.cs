using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblLiqXDisProducto
{
    public int? intFolioLiquidacionDis { get; set; }

    public int intProducto { get; set; }

    public string strProducto { get; set; } = null!;

    public string strTipoProducto { get; set; } = null!;

    public decimal? dblImporte { get; set; }

    public decimal? intExistenciaInicial { get; set; }

    public decimal? intExistenciaFinal { get; set; }

    public decimal? intSalida { get; set; }
}
