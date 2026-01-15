using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblPromocionesDescuento
{
    public int? intIDPromocion { get; set; }

    public decimal? dblDescuento { get; set; }

    public bool? bitActiva { get; set; }

    public decimal? dblMontoMinimo { get; set; }

    public decimal? dblVolumenMinimo { get; set; }

    public string? strFormasPago { get; set; }

    public string? strDiasSemana { get; set; }

    public string? strProductosValidos { get; set; }

    public bool? bitRequiereTarjetaGO { get; set; }

    public DateTime? datFechaInicial { get; set; }

    public DateTime? datFechaFinal { get; set; }

    public string? strHorasValida { get; set; }
}
