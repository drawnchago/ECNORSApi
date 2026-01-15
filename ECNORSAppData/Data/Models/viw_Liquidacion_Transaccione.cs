using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viw_Liquidacion_Transaccione
{
    public int? intZona { get; set; }

    public int? intEstUG { get; set; }

    public int? intSite { get; set; }

    public long Transaccion { get; set; }

    public DateTime datFechaHora { get; set; }

    public string strTipoTransaccion { get; set; } = null!;

    public int intTipoVenta { get; set; }

    public int intProducto { get; set; }

    public int intDispensario { get; set; }

    public int intManguera { get; set; }

    public double dblPrecioUnitario { get; set; }

    public double dblVolumen { get; set; }

    public double dblImporte { get; set; }

    public string? strCliente { get; set; }

    public string? strVehiculo { get; set; }

    public string? strLetraFolio { get; set; }

    public long? intFactura { get; set; }

    public string? strPie1 { get; set; }

    public string? strPie2 { get; set; }

    public int dblVo { get; set; }

    public int dblIo { get; set; }

    public long intSecuencia { get; set; }

    public bool bitTransmitido { get; set; }

    public int intUsuario { get; set; }

    public string? strNomUsuario { get; set; }

    public int? intImpresion { get; set; }

    public long? intFolioLote { get; set; }

    public long intFolioCorte { get; set; }
}
