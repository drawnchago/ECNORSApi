using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class rel_rol_modulo
{
    public long Id_usuario_rol { get; set; }

    public long Id_modulo { get; set; }

    public bool isRol { get; set; }

    public bool isAdmin { get; set; }
}
