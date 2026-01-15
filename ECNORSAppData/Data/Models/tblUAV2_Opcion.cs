using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblUAV2_Opcion
{
    public int OpcionID { get; set; }

    public string Etiqueta { get; set; } = null!;

    public string Llave { get; set; } = null!;

    public bool Activa { get; set; }

    public int Orden { get; set; }
}
