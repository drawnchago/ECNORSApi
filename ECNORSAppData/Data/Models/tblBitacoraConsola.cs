using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblBitacoraConsola
{
    public int id { get; set; }

    public byte[]? strMensaje { get; set; }

    public byte[]? strInterfaz { get; set; }

    public byte[]? strComando { get; set; }

    public DateTime? datFecha { get; set; }
}
