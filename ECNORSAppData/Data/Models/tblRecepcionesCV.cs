using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblRecepcionesCV
{
    public int intID { get; set; }

    public int intFolioRecepcion { get; set; }

    public long intTanque { get; set; }

    public long intProducto { get; set; }

    public DateTime datFechaHoraInicial { get; set; }

    public DateTime datFechaHoraFinal { get; set; }

    public double? dblVolumenInicial { get; set; }

    public double? dblTCVolumenInicial { get; set; }

    public double? dblAguaInicial { get; set; }

    public double? dblTemperaturaInicial { get; set; }

    public double? dblVolumenFinal { get; set; }

    public double? dblTCVolumenFinal { get; set; }

    public double? dblAguaFinal { get; set; }

    public double? dblTemperaturaFinal { get; set; }

    public double? dblAlturaFinal { get; set; }

    public double? dblAlturaInicial { get; set; }

    public DateTime? datFechaAlta { get; set; }

    public long? intFolioLote { get; set; }

    public bool? bitCapturado { get; set; }

    public int? intOctanajeTeorico { get; set; }

    public bool? bitContieneEtanolTeorico { get; set; }

    public decimal? intEtanolTeorico { get; set; }

    public string? strTipoRegistro { get; set; }
}
