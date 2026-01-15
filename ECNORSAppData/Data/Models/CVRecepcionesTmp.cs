using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class CVRecepcionesTmp
{
    public int? FolioRecepcion { get; set; }

    public string? RFC { get; set; }

    public string? SIIC { get; set; }

    public string? Tanque { get; set; }

    public string? Producto { get; set; }

    public decimal? VolumenInicial { get; set; }

    public decimal? VolumenFinal { get; set; }

    public decimal? VolumenRecepcion { get; set; }

    public decimal? Temperatura { get; set; }

    public string? Terminal { get; set; }

    public string? TipoDocto { get; set; }

    public string? FechaDocto { get; set; }

    public string? FolioDocto { get; set; }

    public decimal? VolumenDocto { get; set; }

    public string? FechaRecepcion { get; set; }

    public string? FECHAHORAGNAARC { get; set; }

    public string? Vehiculo { get; set; }

    public string? TipoRegistro { get; set; }

    public int? FolioRecepcion2 { get; set; }

    public int? TotalRecepciones { get; set; }

    public int? TotalDocumentos { get; set; }
}
