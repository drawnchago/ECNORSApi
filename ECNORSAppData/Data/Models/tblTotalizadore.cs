using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTotalizadore
{
    public long intID { get; set; }

    public long intFolioCorte { get; set; }

    public int intDispensario { get; set; }

    public int intManguera { get; set; }

    public int intProducto { get; set; }

    public int intIsla { get; set; }

    public double dblTotalLitrosInicial { get; set; }

    public double dblTotalImporteInicial { get; set; }

    public DateTime datFechaInicio { get; set; }

    public double? dblTotalLitrosFinal { get; set; }

    public double? dblTotalImporteFinal { get; set; }

    public DateTime? datFechaFinal { get; set; }

    public virtual tblFoliosCorte intFolioCorteNavigation { get; set; } = null!;

    public virtual tblProducto intProductoNavigation { get; set; } = null!;

    public virtual tblManguera tblManguera { get; set; } = null!;
}
