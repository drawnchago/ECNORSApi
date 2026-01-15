using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTPV
{
    public int intTPV { get; set; }

    public string strDescripcion { get; set; } = null!;

    public string strPC { get; set; } = null!;

    public int intPuertoHID { get; set; }

    public int intPuertoCardReader { get; set; }

    public int intPuertoImpresora { get; set; }

    public bool bitActivo { get; set; }

    public bool? bitValidarValeOrsan { get; set; }

    public bool? bitValidarTerminalBancaria { get; set; }

    public int? intTerminal { get; set; }

    public int? intTipoDispositivo { get; set; }

    public string? strIdentificador { get; set; }

    public string? strImpresora { get; set; }

    public string? strMotorPagos { get; set; }

    public bool? bitMotorPagosProd { get; set; }

    public virtual ICollection<tblTransaccione> tblTransacciones { get; set; } = new List<tblTransaccione>();
}
