using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblRecepcionesEnc
{
    public long intRecepcion { get; set; }

    public int intProveedor { get; set; }

    public long intFolioFactura { get; set; }

    public DateTime? datFechaRecepcion { get; set; }

    public double? dblIVA { get; set; }

    public double? dblImporteTotal { get; set; }

    public int? intNoPartidas { get; set; }

    public string? strUsuarioCaptura { get; set; }

    public DateTime? datFechaCaptura { get; set; }

    public string? strPCCaptura { get; set; }

    public string? strUsuarioModificacion { get; set; }

    public DateTime? datFechaModificacion { get; set; }

    public string? strPCModificacion { get; set; }

    public virtual ICollection<tblRecepcionesDet> tblRecepcionesDets { get; set; } = new List<tblRecepcionesDet>();
}
