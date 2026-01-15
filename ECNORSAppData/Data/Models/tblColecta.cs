using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblColecta
{
    public int intFolioColecta { get; set; }

    public DateTime datFecha { get; set; }

    public int intUsuario { get; set; }

    public int? intFolioCorte { get; set; }

    public decimal dblVales { get; set; }

    public decimal dblEfectivo { get; set; }

    public decimal dblTotal { get; set; }
}
