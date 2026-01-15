using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblArticulosPromocionale
{
    public int intID { get; set; }

    public string? strCodigoPromocional { get; set; }

    public string? strCodigoBarrasProducto { get; set; }

    public int? intEstatus { get; set; }
}
