using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblUAV2_SolicitudAutorizacion
{
    public Guid SolicitudID { get; set; }

    public DateTime Fecha { get; set; }

    public int UsuarioID { get; set; }

    public int TPVID { get; set; }

    public int DispensarioID { get; set; }

    public int MangueraID { get; set; }

    public int ProductoID { get; set; }

    public int TipoDespachoID { get; set; }

    public int? TipoVentaID { get; set; }

    public decimal Pesos { get; set; }

    public decimal Litros { get; set; }

    public int? Secuencia { get; set; }

    public bool? Autorizada { get; set; }

    public DateTime? FechaAutorizacion { get; set; }

    public string? Mensaje { get; set; }

    public string? Serie { get; set; }

    public string? URL { get; set; }

    public string? JSONRequest { get; set; }

    public string? JSONResponse { get; set; }

    public bool? MobilFleet { get; set; }

    public string? NumeroEstacion { get; set; }

    public string? CheckIn { get; set; }
}
