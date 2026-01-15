using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblRecepcionDictamene
{
    public int? intFolioRecepcion { get; set; }

    public string? strRFCDictamen { get; set; }

    public string? strLoteDictamen { get; set; }

    public string? strNumeroFolioDictamen { get; set; }

    public DateTime? strFechaEmisionDictamen { get; set; }

    public string? strResultadoDictamen { get; set; }

    public string? strNombreDictamen { get; set; }

    public int intidDictamen { get; set; }
}
