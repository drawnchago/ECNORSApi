using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblProcesoPasoManager
{
    public int? intIDPaso { get; set; }

    public int? intProceso { get; set; }

    public int? intOrden { get; set; }

    public int? intSumaPasoCorrecto { get; set; }

    public int? intSumaPasoIncorrecto { get; set; }
}
