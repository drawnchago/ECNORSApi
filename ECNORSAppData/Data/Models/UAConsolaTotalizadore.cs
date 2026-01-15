using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class UAConsolaTotalizadore
{
    public int ID { get; set; }

    public Guid? IdentificadorTotalizador { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Mensaje { get; set; }

    public string? Dispensario { get; set; }

    public string? Producto { get; set; }

    public decimal? Total { get; set; }
}
