using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblUATransaccionUUID
{
    public int intIdTransaccionUUID { get; set; }

    public int? intEstacion { get; set; }

    public string? strRFCEmisor { get; set; }

    public string? strRFCReceptor { get; set; }

    public int intTransaccion { get; set; }

    public string? strDV { get; set; }

    public int? intProducto { get; set; }

    public DateTime? datFecha { get; set; }

    public decimal? dblImporte { get; set; }

    public decimal? dblCantidad { get; set; }

    public decimal? dblTotal { get; set; }

    public bool? bitPublicoGeneral { get; set; }

    public string? strUUID { get; set; }

    public string? strSerie { get; set; }

    public int? intFolio { get; set; }

    public DateTime? datFechaAlta { get; set; }

    public DateTime? datFechaModificacion { get; set; }
}
