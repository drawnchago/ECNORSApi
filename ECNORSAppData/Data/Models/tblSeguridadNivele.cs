using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblSeguridadNivele
{
    public int intGrupoUsuario { get; set; }

    public int intModulo { get; set; }

    public int intNivel { get; set; }

    public string strDescripcion { get; set; } = null!;

    public virtual tblSeguridadModulo intModuloNavigation { get; set; } = null!;
}
