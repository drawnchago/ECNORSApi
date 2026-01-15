using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblMedidore
{
    public int? intTipoMedidor { get; set; }

    public int? intIdMedidor { get; set; }

    public bool? bitEstatus { get; set; }

    public string? strIdSistemaMedicion { get; set; }

    public string? strDescripcion { get; set; }

    public string? strUbicacion { get; set; }

    public DateTime? datFechaVigenciaCertificado { get; set; }

    public decimal? dblIncertidumbre { get; set; }

    public string? strClaveAlmacenamiento { get; set; }

    public DateTime? datFechaCalibracion { get; set; }
}
