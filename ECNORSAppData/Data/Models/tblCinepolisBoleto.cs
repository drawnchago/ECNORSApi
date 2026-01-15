using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblCinepolisBoleto
{
    public string strCodigoSolicitud { get; set; } = null!;

    public string strFolio { get; set; } = null!;

    public string strTitulo { get; set; } = null!;

    public string strPrecio { get; set; } = null!;

    public DateTime datFecha { get; set; }

    public string strSucursal { get; set; } = null!;

    public string strAgente { get; set; } = null!;

    public string strDescripcion { get; set; } = null!;

    public string strTerminos { get; set; } = null!;

    public string strImgBoleto { get; set; } = null!;

    public string strImgEmpresa { get; set; } = null!;

    public string strImgGoBenefits { get; set; } = null!;

    public int intCodigo { get; set; }

    public string strMensaje { get; set; } = null!;

    public string strHTML { get; set; } = null!;

    public string strPrintHTML { get; set; } = null!;
}
