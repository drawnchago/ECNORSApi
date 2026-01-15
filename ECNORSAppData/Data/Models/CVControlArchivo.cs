using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class CVControlArchivo
{
    public string Archivo { get; set; } = null!;

    public int EstacionID { get; set; }

    public Guid SesionID { get; set; }

    public string Origen { get; set; } = null!;

    public string Destino { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string Estado { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public DateTime? FechaArchivo { get; set; }

    public string? Detalles { get; set; }

    public int? SegundosIntegracion { get; set; }

    public int? RegistrosIntegracion { get; set; }

    public int? SegundosRecoleccion { get; set; }

    public string? CodigoRespuesta { get; set; }

    public DateTime? FechaRespuesta { get; set; }

    public int? FolioLote { get; set; }
}
