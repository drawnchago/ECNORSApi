using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblCinepoli
{
    public DateTime datFecha { get; set; }

    public string strIdSesion { get; set; } = null!;

    public int intUsuario { get; set; }

    public int intDispositivo { get; set; }

    public int intCantidad { get; set; }

    public int intProducto { get; set; }

    public bool bitError { get; set; }

    public string? strMensajeError { get; set; }

    public int? intCodigo { get; set; }

    public string? strMensaje { get; set; }

    public string? strFormato { get; set; }

    public string? strCodigoSolicitud { get; set; }

    public bool? bitImpreso { get; set; }

    public string? strPrintHTML { get; set; }

    public string? strHTML { get; set; }

    public DateTime? datFechaConfirmacionImpresion { get; set; }

    public int? intFolioCorte { get; set; }

    public int? intCantidadRecibida { get; set; }

    public string? strFolios { get; set; }
}
