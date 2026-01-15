using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblUAV2_PagoTerminal
{
    public Guid PagoID { get; set; }

    public DateTime Fecha { get; set; }

    public long TransaccionID { get; set; }

    public int FormaPagoID { get; set; }

    public decimal Importe { get; set; }

    public string? Respuesta { get; set; }

    public int? TerminalID { get; set; }

    public string? Estacion { get; set; }

    public int? UsuarioID { get; set; }

    public string? TerminalSerie { get; set; }

    public string? TerminalVersion { get; set; }

    public string? Mensaje { get; set; }

    public string? StackTrace { get; set; }

    public bool? Exitoso { get; set; }
}
