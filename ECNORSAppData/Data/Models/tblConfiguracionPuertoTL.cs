using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblConfiguracionPuertoTL
{
    public int? intPuerto { get; set; }

    public int? intBaudios { get; set; }

    public string? strParidad { get; set; }

    public int? intDatos { get; set; }

    public int? intBitParada { get; set; }

    public string? strCaraterParidad { get; set; }

    public long? intMiliSegundos { get; set; }
}
