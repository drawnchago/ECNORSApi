using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblTiposVentum
{
    public int intTipoVenta { get; set; }

    public string strDescripcion { get; set; } = null!;

    public bool bitEstatus { get; set; }

    public bool? bitActivoCombustible { get; set; }

    public bool? bitActivoProducto { get; set; }

    public bool? bitFidelidad { get; set; }

    public bool? bitTerminal { get; set; }

    public int? intProceso { get; set; }

    public string? strControlPago { get; set; }

    public string? strValorControlPago { get; set; }

    public bool? bitValidaMontoFinal { get; set; }

    public bool? bitPagaDirecto { get; set; }

    public int? intMoneda { get; set; }

    public int? dblLimite { get; set; }

    public bool? bitRequiereCorteSeguridad { get; set; }

    public bool? bitRequiereDesgloce { get; set; }

    public bool? bitDigitoVerificador { get; set; }

    public bool? bitFacturable { get; set; }

    public bool? bitReimprimeOriginal { get; set; }

    public virtual ICollection<tblTransaccione> tblTransacciones { get; set; } = new List<tblTransaccione>();
}
