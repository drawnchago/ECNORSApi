using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblBitacoraMensaje
{
    public int intUsuario { get; set; }

    public DateTime datFechaCreado { get; set; }

    public string strMensaje { get; set; } = null!;

    public DateTime? datFechaVisto { get; set; }
}
