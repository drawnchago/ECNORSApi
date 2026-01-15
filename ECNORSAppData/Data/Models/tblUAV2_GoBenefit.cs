using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblUAV2_GoBenefit
{
    public DateTime Fecha { get; set; }

    public string Transaccion { get; set; } = null!;

    public bool Exitoso { get; set; }

    public bool Cancelado { get; set; }

    public string? Mensaje { get; set; }

    public string? Cantidad { get; set; }

    public string? Puntos { get; set; }

    public string? Descuento { get; set; }

    public string? Monto { get; set; }

    public string? Saldo { get; set; }

    public string? ProductoID { get; set; }

    public string? TipoVenta { get; set; }

    public string? TipoBoletos { get; set; }

    public string? CantidadBoletos { get; set; }

    public string? Folios { get; set; }

    public string? AcumulacionUrl { get; set; }

    public string? AcumulacionRequest { get; set; }

    public string? AcumulacionResponse { get; set; }

    public string? Excepcion { get; set; }

    public bool? Aditivos { get; set; }
}
