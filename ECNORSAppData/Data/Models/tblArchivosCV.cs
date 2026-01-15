using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblArchivosCV
{
    public string strFecha { get; set; } = null!;

    public string strNombreArchivo { get; set; } = null!;

    public byte[] byteArchivo { get; set; } = null!;

    public DateTime datFechaAlta { get; set; }
}
