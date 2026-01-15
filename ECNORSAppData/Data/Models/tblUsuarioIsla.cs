using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblUsuarioIsla
{
    public long intID { get; set; }

    public long intFolioCorte { get; set; }

    public int intUsuario { get; set; }

    public int intIsla { get; set; }

    public int? intTurno { get; set; }

    public bool bitIDActivo { get; set; }

    public DateTime datFechaAlta { get; set; }

    public virtual tblFoliosCorte intFolioCorteNavigation { get; set; } = null!;

    public virtual tblIsla intIslaNavigation { get; set; } = null!;

    public virtual tblUsuario intUsuarioNavigation { get; set; } = null!;
}
