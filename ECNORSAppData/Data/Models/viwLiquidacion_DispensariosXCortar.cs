using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viwLiquidacion_DispensariosXCortar
{
    public int intIsla { get; set; }

    public int intDispensario { get; set; }

    public int? intManguera { get; set; }

    public int? intProducto { get; set; }
}
