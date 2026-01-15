using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblFoliosCorte
{
    public long intID { get; set; }

    public long intFolioCorte { get; set; }

    public DateTime? datFechaContable { get; set; }

    public int? intTurno { get; set; }

    public DateTime datFechaInicial { get; set; }

    public DateTime? datFechaFinal { get; set; }

    public DateTime? datFechaLiquidacion { get; set; }

    public bool bitLiquidado { get; set; }

    public virtual ICollection<tblLiquidacionEnc> tblLiquidacionEncs { get; set; } = new List<tblLiquidacionEnc>();

    public virtual ICollection<tblTotalizadore> tblTotalizadores { get; set; } = new List<tblTotalizadore>();

    public virtual ICollection<tblTransaccione> tblTransacciones { get; set; } = new List<tblTransaccione>();

    public virtual ICollection<tblUsuarioIsla> tblUsuarioIslas { get; set; } = new List<tblUsuarioIsla>();
}
