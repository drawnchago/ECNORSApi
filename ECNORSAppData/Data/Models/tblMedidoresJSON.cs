using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblMedidoresJSON
{
    public int? intIdTanque { get; set; }

    public int? intIdDispensario { get; set; }

    public string? strSistemaMedicion { get; set; }

    public string? strDescripcion { get; set; }

    public DateTime? datVigenciaSistemaMedicion { get; set; }

    public decimal? dblIncertidumbreSistemaMedicion { get; set; }
}
