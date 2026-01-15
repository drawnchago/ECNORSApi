using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tmpVentas1CV
{
    public string? Cabecera { get; set; }

    public string? RFC { get; set; }

    public string? SIIC { get; set; }

    public int? Transaccion { get; set; }

    public string? intDispensario { get; set; }

    public string? intManguera { get; set; }

    public string? Producto { get; set; }

    public decimal? Volumen { get; set; }

    public decimal? dblPrecioUnitario { get; set; }

    public decimal? dblImporte { get; set; }

    public string? FechaTransaccion { get; set; }

    public string? FECHAHORAGNAARC { get; set; }
}
