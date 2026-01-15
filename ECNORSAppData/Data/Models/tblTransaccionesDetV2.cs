using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTransaccionesDetV2
{
    public int intTransaccion { get; set; }

    public int intFormaPago { get; set; }

    public decimal decImporte { get; set; }

    public int intMovimiento { get; set; }

    public string? strTarjeta { get; set; }

    public string? strCliente { get; set; }

    public string? strVehiculo { get; set; }

    public string? strOdometro { get; set; }

    public string? strPie1 { get; set; }

    public string? strPie2 { get; set; }

    public string? strPie3 { get; set; }

    public string? strPie4 { get; set; }

    public string? strBandaMagnetica { get; set; }
}
