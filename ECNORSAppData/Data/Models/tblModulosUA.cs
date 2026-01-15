using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblModulosUA
{
    public long Id { get; set; }

    public long IdPadre { get; set; }

    public string Nombre { get; set; } = null!;

    public bool IsModulo { get; set; }

    public string? Descripcion { get; set; }

    public string? pathString { get; set; }

    public bool? hasChilds { get; set; }

    public string? dllName { get; set; }
}
