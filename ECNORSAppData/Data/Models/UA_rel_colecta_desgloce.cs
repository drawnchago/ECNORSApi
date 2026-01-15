using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class UA_rel_colecta_desgloce
{
    public long? IdColecta { get; set; }

    public long? IdDesgloce { get; set; }

    public bool? bitActivo { get; set; }
}
