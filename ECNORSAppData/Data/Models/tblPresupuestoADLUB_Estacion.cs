using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblPresupuestoADLUB_Estacion
{
    public int intAño { get; set; }

    public int intMes { get; set; }

    public int intProducto { get; set; }

    public int intMeta { get; set; }

    public int intCumplido { get; set; }

    public DateTime datFechaActualizacion { get; set; }

    public int intUsuario { get; set; }
}
