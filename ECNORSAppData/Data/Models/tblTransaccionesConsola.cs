using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTransaccionesConsola
{
    public int ID { get; set; }

    public int intDispensario { get; set; }

    public int intProducto { get; set; }

    public decimal dblPrecio { get; set; }

    public decimal dblVolumen { get; set; }

    public decimal? dblMontoProgramado { get; set; }

    public decimal dblMonto { get; set; }

    public int intFolioSecuencia { get; set; }

    public decimal? decTotalizadorFinal { get; set; }

    public bool intManual { get; set; }

    public decimal? dblTemperatura { get; set; }

    public bool bitExisteEnBitacora { get; set; }

    public bool bitExisteEnTransacciones { get; set; }

    public string? strObservaciones { get; set; }

    public DateTime FechaRegistro { get; set; }
}
