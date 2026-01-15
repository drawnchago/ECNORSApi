using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class UA_tbl_Detalle_Desgloce_Denominacione
{
    public int intID { get; set; }

    public int intIDDesgloce { get; set; }

    public decimal dblDenominacion { get; set; }

    public decimal dblCantidad { get; set; }

    public decimal dblTotal { get; set; }

    public string strTipo { get; set; } = null!;
}
