using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viw_Liquidacion_Rep
{
    public long FolioL { get; set; }

    public long FolioC { get; set; }

    public int Turno { get; set; }

    public int Isla { get; set; }

    public int _Usuario { get; set; }

    public string UsuarioIsla { get; set; } = null!;

    public string DespachadoresIsla { get; set; } = null!;

    public string? DescProd { get; set; }

    public string Producto { get; set; } = null!;

    public double PrecioActual { get; set; }

    public double? PrecioHist { get; set; }

    public double? Inicial { get; set; }

    public double? ENT { get; set; }

    public double? Final { get; set; }

    public double? Venta { get; set; }

    public string FormaPago { get; set; } = null!;

    public double? ImporteTotFormaPAgo { get; set; }

    public int intProducto { get; set; }
}
