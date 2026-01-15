using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viwLiquidacion_Totalizadore
{
    public long intFolioCorte { get; set; }

    public int intIsla { get; set; }

    public int intDispensario { get; set; }

    public int intManguera { get; set; }

    public int intProducto { get; set; }

    public double dblTotalLitrosInicial { get; set; }

    public double? dblTotalLitrosFinal { get; set; }

    public double? dblTotalLitrosContador { get; set; }

    public double? dblTotalLitrosTransacciones { get; set; }

    public double? dblTotalImporteContador { get; set; }

    public double? dblTotalImporteTransacciones { get; set; }

    public DateTime datFechaInicio { get; set; }

    public DateTime? datFechaFinal { get; set; }

    public double dblTotalImporteInicial { get; set; }

    public double? dblTotalImporteFinal { get; set; }

    public string? strDescripcion { get; set; }
}
