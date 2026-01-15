using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblBitacora_Duplicada
{
    public long intId { get; set; }

    public long? intSecuencia { get; set; }

    public string? strTipoTransaccion { get; set; }

    public DateTime? datFechaHora { get; set; }

    public int? intTPV { get; set; }

    public int? intTipoVenta { get; set; }

    public int? intDispensario { get; set; }

    public int? intManguera { get; set; }

    public int? intProducto { get; set; }

    public int? intUsuario { get; set; }

    public string? strTarjeta { get; set; }

    public string? strCliente { get; set; }

    public string? strVehiculo { get; set; }

    public string? strOdometro { get; set; }

    public string? strPie1 { get; set; }

    public string? strPie2 { get; set; }

    public string? strPie3 { get; set; }

    public string? strPie4 { get; set; }

    public string? strBandaMagnetica { get; set; }

    public double? dblPrecioUnitario { get; set; }

    public int? intTipoProgramado { get; set; }

    public double? dblProgramado { get; set; }

    public double? dblVendido { get; set; }

    public double? dblVolumenVendido { get; set; }

    public bool? bitCerrada { get; set; }
}
