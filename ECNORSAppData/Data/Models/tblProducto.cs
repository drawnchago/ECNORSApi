using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblProducto
{
    public int intProducto { get; set; }

    public string strDescripcion { get; set; } = null!;

    public int intTipoProducto { get; set; }

    public int intPresentacion { get; set; }

    public string? strFolioPemex { get; set; }

    public double? dblCosto { get; set; }

    public double dblPrecioU { get; set; }

    public bool bitEstatus { get; set; }

    public DateTime? datFechaAlta { get; set; }

    public string? strUsuarioAlta { get; set; }

    public string? strMaquinaAlta { get; set; }

    public bool? bitCapturaManual { get; set; }

    public string? strCodigoBarras { get; set; }

    public DateTime? datFechaActualizacion { get; set; }

    public string? strUsuarioActualizacion { get; set; }

    public bool bitCambioTablero { get; set; }

    public string intPuertoCOMTablero { get; set; } = null!;

    public int intTablero { get; set; }

    public string? strClaveProducto { get; set; }

    public string? strClaveSubProducto { get; set; }

    public int? intOctanaje { get; set; }

    public string? strEtanol { get; set; }

    public decimal? intEtanol { get; set; }

    public string? strOtroCombustible { get; set; }

    public string? strMarca { get; set; }

    public bool? bitEditable { get; set; }

    public bool? bitBloquear { get; set; }

    public string? strClaveIdentificacion { get; set; }

    public virtual tblPresentacione intPresentacionNavigation { get; set; } = null!;

    public virtual tblTiposProducto intTipoProductoNavigation { get; set; } = null!;

    public virtual ICollection<tblExistencia> tblExistencia { get; set; } = new List<tblExistencia>();

    public virtual ICollection<tblManguera> tblMangueras { get; set; } = new List<tblManguera>();

    public virtual ICollection<tblMovimientosInvDet> tblMovimientosInvDets { get; set; } = new List<tblMovimientosInvDet>();

    public virtual ICollection<tblRecepcionesDet> tblRecepcionesDets { get; set; } = new List<tblRecepcionesDet>();

    public virtual ICollection<tblTanque> tblTanques { get; set; } = new List<tblTanque>();

    public virtual ICollection<tblTotalizadore> tblTotalizadores { get; set; } = new List<tblTotalizadore>();

    public virtual ICollection<tblTransaccione> tblTransacciones { get; set; } = new List<tblTransaccione>();
}
