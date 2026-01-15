using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblNotificationsIP
{
    public int intId { get; set; }

    public string? strIp { get; set; }

    public string? strHostName { get; set; }

    public bool? btActivo { get; set; }
}
