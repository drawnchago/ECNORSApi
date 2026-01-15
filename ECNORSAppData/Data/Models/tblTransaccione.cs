using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTransaccione
{
    public long intID { get; set; }

    public long intFolioCorte { get; set; }

    public long intTransaccion { get; set; }

    public string strTipoTransaccion { get; set; } = null!;

    public long intSecuencia { get; set; }

    public DateTime datFechahora { get; set; }

    public int intTPV { get; set; }

    public int intTipoVenta { get; set; }

    public int intDispensario { get; set; }

    public int intManguera { get; set; }

    public int intProducto { get; set; }

    public double dblPrecioUnitario { get; set; }

    public double dblVolumen { get; set; }

    public double dblImporte { get; set; }

    public int intUsuario { get; set; }

    public string? strTarjeta { get; set; }

    public string? strCliente { get; set; }

    public string? strVehiculo { get; set; }

    public string? strOdometro { get; set; }

    public string? strPie1 { get; set; }

    public string? strPie2 { get; set; }

    public string? strPie3 { get; set; }

    public string? strPie4 { get; set; }

    public string? strBandaMagnetica { get; set; }

    public int? intImpresion { get; set; }

    public bool bitTransmitido { get; set; }

    public string? strLetraFolio { get; set; }

    public long? intFactura { get; set; }

    public long? intFolioLote { get; set; }

    public bool bitCapturaManual { get; set; }

    public string? strRendimiento { get; set; }

    public string? strTotalizadorFinal { get; set; }

    public int? intFolioSeguridad { get; set; }

    public int? intFacturaCliente { get; set; }

    public string? strFacturaCodigoCliente { get; set; }

    public bool? bitLiquidado { get; set; }

    public int? intFolioLiquidacion { get; set; }

    public double? dblCheckSum { get; set; }

    public string? strRfcCliente { get; set; }

    public decimal? dblTemperatura { get; set; }

    public virtual tblDispensario intDispensarioNavigation { get; set; } = null!;

    public virtual tblFoliosCorte intFolioCorteNavigation { get; set; } = null!;

    public virtual tblProducto intProductoNavigation { get; set; } = null!;

    public virtual tblTPV intTPVNavigation { get; set; } = null!;

    public virtual tblTiposVentum intTipoVentaNavigation { get; set; } = null!;

    public virtual tblUsuario intUsuarioNavigation { get; set; } = null!;

    public virtual tblTiposTransaccion strTipoTransaccionNavigation { get; set; } = null!;

    public virtual tblManguera tblManguera { get; set; } = null!;
}
