using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblProductosCV
{
    public int intID { get; set; }

    public string? strProducto { get; set; }

    public string? strProductoDescripcion { get; set; }

    public string? strSubproducto { get; set; }

    public string? strSubProductoDescripcion { get; set; }

    public string? strMarca { get; set; }

    public string? strMarcaDescripcion { get; set; }
}
