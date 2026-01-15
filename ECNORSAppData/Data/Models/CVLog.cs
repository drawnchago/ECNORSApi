using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class CVLog
{
    public Guid MensajeID { get; set; }

    public DateTime Fecha { get; set; }

    public Guid SesionID { get; set; }

    public int EstacionID { get; set; }

    public string Aplicacion { get; set; } = null!;

    public string Proceso { get; set; } = null!;

    public string Origen { get; set; } = null!;

    public string Mensaje { get; set; } = null!;

    public string? Detalles { get; set; }

    public bool EsError { get; set; }
}
