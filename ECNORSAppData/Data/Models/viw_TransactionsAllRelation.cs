using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viw_TransactionsAllRelation
{
    public long intFolioCorte { get; set; }

    public long intTransaccion { get; set; }

    public string? strDescripcion { get; set; }

    public string TipoTransaccion { get; set; } = null!;

    public DateTime datFechahora { get; set; }

    public int intTPV { get; set; }

    public string NomTPV { get; set; } = null!;

    public int intTipoVenta { get; set; }

    public string NomTipoVenta { get; set; } = null!;

    public int intDispensario { get; set; }

    public int intManguera { get; set; }

    public int intProducto { get; set; }

    public string NomProducto { get; set; } = null!;

    public int intIsla { get; set; }

    public string NomIsla { get; set; } = null!;

    public double dblVolumen { get; set; }

    public double dblImporte { get; set; }

    public int intUsuario { get; set; }

    public string Nombre { get; set; } = null!;

    public string Paterno { get; set; } = null!;

    public string Materno { get; set; } = null!;

    public string? strIdentificador { get; set; }

    public bool bitActivo { get; set; }

    public long? intFolioLote { get; set; }

    public short? CodigoPemex { get; set; }

    public int? NumeroLote { get; set; }

    public string? Archivo { get; set; }

    public string? NomCpdigoPemex { get; set; }
}
