using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblBoletosGOBenefit
{
    public string? Empresa { get; set; }

    public int? NoEstacion { get; set; }

    public string? NombreEstacion { get; set; }

    public string? NoUsuario { get; set; }

    public string? NombreUsuario { get; set; }

    public string? TipoBoleto { get; set; }

    public string? Folio { get; set; }

    public decimal? Monto { get; set; }

    public DateTime? Fecha { get; set; }

    public DateTime? FechaAlta { get; set; }

    public int? PagoPuntos { get; set; }
}
