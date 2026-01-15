using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblPermisosObjeto
{
    public Guid? strGuidPermiso { get; set; }

    public int? intIDObjeto { get; set; }

    public bool? bitValor { get; set; }

    public bool? bitUsuario { get; set; }
}
