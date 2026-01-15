using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblPemexConfiguracion
{
    public string? strPath_Conexion { get; set; }

    public string? strPath_XML { get; set; }

    public string? strUsuarioCV { get; set; }

    public string? strPasswordCV { get; set; }

    public string? strHora { get; set; }

    public string? strHoraFinal { get; set; }

    public string? strMinutos { get; set; }

    public string? strMinutosParaconsultar { get; set; }

    public string? strMinutosParaGenerar { get; set; }

    public string? strHoraGeneracion { get; set; }

    public string? strRutaCer { get; set; }

    public string? strRutaKey { get; set; }

    public string? strPassKey { get; set; }
}
