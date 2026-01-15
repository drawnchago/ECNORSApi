using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class UA_rel_desgloce_denominacion
{
    public long IdDesgloce { get; set; }

    public long IdDenominacion { get; set; }

    public string tipo { get; set; } = null!;

    public double cantidad { get; set; }

    public double total { get; set; }
}
