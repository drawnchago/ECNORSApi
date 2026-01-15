using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblDictamenDocumento
{
    public int intIdDictamenDocumento { get; set; }

    public int? intFolioRecepcion { get; set; }

    public string? strNombreArchivo { get; set; }

    public byte[]? bytArchivo { get; set; }

    public DateTime? datFechaAlta { get; set; }

    public DateTime? datFechaModificacion { get; set; }

    public int? intidDictamen { get; set; }
}
