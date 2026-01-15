using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblDispensario
{
    public int intDispensario { get; set; }

    public int intIsla { get; set; }

    public string? strTipoSurtidor { get; set; }

    public string? strRFID { get; set; }

    public DateTime? datFechaLectura { get; set; }

    public int? intEstatus { get; set; }

    public int? intNumeroFisico { get; set; }

    public bool bitGenerado { get; set; }

    public bool bitSirviendo { get; set; }

    public bool bitDespacho { get; set; }

    public virtual tblIsla intIslaNavigation { get; set; } = null!;

    public virtual ICollection<tblManguera> tblMangueras { get; set; } = new List<tblManguera>();

    public virtual ICollection<tblTransaccione> tblTransacciones { get; set; } = new List<tblTransaccione>();
}
