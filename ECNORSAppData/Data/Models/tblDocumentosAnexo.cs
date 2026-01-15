using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblDocumentosAnexo
{
    public int intIdDocumentoAnexo { get; set; }

    public int? intFolioRecepcion { get; set; }

    public string? strNombreArchivo { get; set; }

    public string? strObservacion { get; set; }

    public byte[]? bytArchivo { get; set; }

    public DateTime? datFechaAlta { get; set; }

    public DateTime? datFechaModificacion { get; set; }
}
