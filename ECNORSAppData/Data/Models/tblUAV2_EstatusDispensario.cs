using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblUAV2_EstatusDispensario
{
    public Guid LogID { get; set; }

    public DateTime LogDate { get; set; }

    public int DispensarioID { get; set; }

    public int EstatusID { get; set; }

    public bool PuedeCargar { get; set; }

    public int? Secuencia { get; set; }

    public int? TransaccionID { get; set; }
}
