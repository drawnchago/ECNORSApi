using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblDocumentosCV
{
    public int intID { get; set; }

    public string? strTipoDocto { get; set; }

    public DateTime? datFechaDocto { get; set; }

    public long? intFolioDocto { get; set; }

    public double? dblVolumenDocto { get; set; }

    public int? intTerminal { get; set; }

    public string? strClaveVehiculo { get; set; }

    public int? intFolioRecepcion { get; set; }

    public DateTime? datFechaAlta { get; set; }

    public string? strUsuarioAlta { get; set; }

    public long? intFolioLote { get; set; }

    public string? strTerminalAD { get; set; }

    public string? strPermisoAD { get; set; }

    public decimal? dblPrecio { get; set; }

    public string? strPermisoTrans { get; set; }

    public int? intProveedor { get; set; }

    public string? strUUID { get; set; }

    public int? intOctanaje { get; set; }

    public bool? bitContieneEtanol { get; set; }

    public decimal? intEtanol { get; set; }

    public decimal? dblDensidad { get; set; }

    public string? strAclaracion { get; set; }

    public string? strPermisoAlma { get; set; }

    public string? strTipoServicio { get; set; }

    public decimal? intImporte { get; set; }
}
