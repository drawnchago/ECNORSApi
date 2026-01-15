using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblBitacoraVale
{
    public DateTime datFecha { get; set; }

    public int intCliente { get; set; }

    public string strNoVale { get; set; } = null!;

    public int intEstacion { get; set; }

    public string strDispositivo { get; set; } = null!;

    public string strAccion { get; set; } = null!;

    public string? strEstatus { get; set; }

    public string? strRespuesta { get; set; }

    public bool? bitEditable { get; set; }

    public decimal? dblMonto { get; set; }

    public decimal? dblMontoCapturado { get; set; }

    public decimal? dblMontoConsumido { get; set; }

    public int? intTransaccion { get; set; }

    public decimal? dblMontoMinimo { get; set; }

    public decimal? dblMontoMaximo { get; set; }

    public decimal? dblMontoTransaccion { get; set; }
}
