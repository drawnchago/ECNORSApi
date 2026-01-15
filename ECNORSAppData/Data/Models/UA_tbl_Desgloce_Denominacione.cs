using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class UA_tbl_Desgloce_Denominacione
{
    public int intID { get; set; }

    public DateTime datFecha { get; set; }

    public int intTurno { get; set; }

    public string strTurno { get; set; } = null!;

    public int intNoColecta { get; set; }

    public int intFolioCorte { get; set; }

    public string strNoBolsa { get; set; } = null!;

    public decimal dblMonto { get; set; }

    public int intActivo { get; set; }

    public DateTime datfechaAlta { get; set; }

    public DateTime datFechaModif { get; set; }

    public string strUsuarioAlta { get; set; } = null!;

    public string strUsuarioModif { get; set; } = null!;

    public string strMaquinaAlta { get; set; } = null!;

    public string strMaquinaModif { get; set; } = null!;
}
