using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTotalizadores_Copium
{
    public long? intID { get; set; }

    public long? intFolioCorte { get; set; }

    public long? intDispensario { get; set; }

    public long? intManguera { get; set; }

    public long? intProducto { get; set; }

    public long? intIsla { get; set; }

    public double? dblTotalLitrosInicial { get; set; }

    public double? dblTotalImporteInicial { get; set; }

    public DateTime? datFechaInicio { get; set; }

    public double? dblTotalLitrosFinal { get; set; }

    public double? dblTotalImporteFinal { get; set; }

    public DateTime? datFechaFinal { get; set; }
}
