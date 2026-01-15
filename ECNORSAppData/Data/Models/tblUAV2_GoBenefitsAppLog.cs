using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblUAV2_GoBenefitsAppLog
{
    public Guid LogID { get; set; }

    public DateTime LogDate { get; set; }

    public int TerminalID { get; set; }

    public int? ResultCode { get; set; }

    public string? Estacion { get; set; }

    public int? UsuarioID { get; set; }

    public string? TerminalSerie { get; set; }

    public string? TerminalVersion { get; set; }

    public string? Accion { get; set; }

    public string? Transaccion { get; set; }

    public string? GBTerminalID { get; set; }

    public string? EmpleadoID { get; set; }

    public string? EmpleadoNombre { get; set; }

    public string? ProductoID { get; set; }

    public string? ProductoNombre { get; set; }

    public double? PrecioUnitario { get; set; }

    public double? Cantidad { get; set; }

    public double? Total { get; set; }

    public string? FormasPago { get; set; }

    public string? Respuesta { get; set; }
}
