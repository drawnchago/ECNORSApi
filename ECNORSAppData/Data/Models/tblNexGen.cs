using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblNexGen
{
    public string? Mode { get; set; }

    public string? HostID { get; set; }

    public string? DeviceID { get; set; }

    public string? EthernetPort { get; set; }

    public string? CommPort { get; set; }

    public string? Speed { get; set; }

    public string? DataBits { get; set; }

    public string? Parity { get; set; }

    public string? StopsBits { get; set; }

    public string? NumRetries { get; set; }

    public string? TimeOut { get; set; }

    public string? DeviceClass { get; set; }

    public string? ServiceClass { get; set; }

    public string? TraceFormat { get; set; }

    public string? TraceTruncate { get; set; }

    public string? TraceRFA { get; set; }

    public string? RFADevice { get; set; }
}
