using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class UA_tblColecta
{
    public int idColecta { get; set; }

    public DateTime datFecha { get; set; }

    public int intDispensario { get; set; }

    public int intTPV { get; set; }

    public string intFolioCorte { get; set; } = null!;

    public string strDespachador { get; set; } = null!;

    public decimal dblMonto { get; set; }

    public decimal dblPropios { get; set; }

    public decimal dblFiliales { get; set; }

    public string? strMaquinaAlta { get; set; }

    public DateTime? datFechaAlta { get; set; }

    public string strComentario { get; set; } = null!;

    public int intFinTurno { get; set; }

    public bool bitActivo { get; set; }

    public bool bitIsDesglosado { get; set; }
}
