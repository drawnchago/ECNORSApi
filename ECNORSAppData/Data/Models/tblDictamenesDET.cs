using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblDictamenesDET
{
    public int intId { get; set; }

    public string? strFolio { get; set; }

    public int? intProducto { get; set; }

    public decimal? decIndiceOctano { get; set; }

    public decimal? decPorcentajeNoFosil { get; set; }
}
