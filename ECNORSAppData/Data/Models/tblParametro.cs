using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class tblParametro
{
    public string strClavePemex { get; set; } = null!;

    public string strNomEmpresa { get; set; } = null!;

    public string? strRFC { get; set; }

    public string? strDireccion { get; set; }

    public string? strColonia { get; set; }

    public string? strCiudadEstado { get; set; }

    public string? strCodigoPostal { get; set; }

    public string? strTelefono { get; set; }

    public double? dblIVA { get; set; }

    public double? dblRangoRecepciones { get; set; }

    public DateTime? datFechaContable { get; set; }

    public short? intTurnoActual { get; set; }

    public DateTime? datFechaHora { get; set; }

    public string? strClientePemex { get; set; }

    public string strNomSucursal { get; set; } = null!;

    public string strDireccionSucursal { get; set; } = null!;

    public string strColoniaSucursal { get; set; } = null!;

    public string strCiudadEstadoSucursal { get; set; } = null!;

    public long intFolioTransaccion { get; set; }

    public long intFolioSecuencia { get; set; }

    public long intFolioCorte { get; set; }

    public long? intFolioRecepcion { get; set; }

    public long? intFolioLiquidacion { get; set; }

    public long? intFolioLote { get; set; }

    public int? intZona { get; set; }

    public int? intEstUG { get; set; }

    public int? intSite { get; set; }

    public int? intMaxImpresiones { get; set; }

    public string? strPCCTG { get; set; }

    public string? strIPCTG { get; set; }

    public int? intPuertoCTG { get; set; }

    public double? dblHorasLimiteLiquidacion { get; set; }

    public int? intSegundosAutorizacion { get; set; }

    public bool? bitMostrarTotalProductos { get; set; }

    public double? dblLimiteImporte { get; set; }

    public double? dblLimiteLitros { get; set; }

    public bool? bitActualizarPrecios { get; set; }

    public decimal? dblcompensacionImporte { get; set; }

    public decimal? dblCompensacionLitros { get; set; }

    public string? strNoCorresponsal { get; set; }

    public string? strActividad { get; set; }

    public string? strVersion { get; set; }

    public int? intSegundosTransaccion { get; set; }

    public string? strDirectorioActualizaciones { get; set; }

    public int? intTipoCorte { get; set; }

    public bool? bitLiquidacionManual { get; set; }

    public string? strMode_BTE { get; set; }

    public string? strClienteID_BTE { get; set; }

    public string? strName_BTE { get; set; }

    public string? strPassword_BTE { get; set; }

    public string? strMarcaDispensario { get; set; }

    public string? strVersionConsola { get; set; }

    public bool? bitPropinaPorcentaje { get; set; }

    public double? dblPropinaMax { get; set; }

    public bool? bitActivaCodigoBarras { get; set; }

    public bool? bitActivaTarjeta { get; set; }

    public int? intOpcionActiva { get; set; }

    public int? intPorcentajeFR { get; set; }

    public int? intTiempoFR { get; set; }

    public string? strIpGasBoy { get; set; }

    public int? intPuertoGasBoy { get; set; }

    public int? intModoDebugLector { get; set; }

    public string? strConsola { get; set; }

    public int? intFolioSeguridadActual { get; set; }

    public decimal? dblLimiteCorteSeguridad { get; set; }

    public int? intUltimoParche { get; set; }

    public string? strWEBSITE { get; set; }

    public string? strMarcaGasolinera { get; set; }

    public int? intFolioColecta { get; set; }

    public bool? bitValidaCobro { get; set; }

    public int? intHoraInicial_SoloUG { get; set; }

    public int? intHoraFinal_SoloUG { get; set; }

    public bool? bitPermiteCupones { get; set; }

    public string? strUserCinepolis { get; set; }

    public string? strPassCinepolis { get; set; }

    public int? intTiempoEsperaCinepolis { get; set; }

    public int? intIntentosConsultaCinepolis { get; set; }

    public int? intCantidadTopeCinepolis { get; set; }

    public int? intProgramaGo { get; set; }

    public string? strUserGoBenefits { get; set; }

    public string? strPasswordGoBenefits { get; set; }

    public int? intIntentosLogin { get; set; }

    public int? intPasswordsRepetidos { get; set; }

    public int? intMesesCambioPass { get; set; }

    public int? intDiasFrecuenciaCalibracion { get; set; }

    public string? strURLTablero { get; set; }

    public string? strRFCRepresentante { get; set; }

    public string? strRFCProveedor { get; set; }

    public decimal? dblLatitud { get; set; }

    public decimal? dblLongitud { get; set; }

    public bool? bitFacturacionUA { get; set; }

    public bool? bitProductosCentralizados { get; set; }

    public bool? bitDescuentoGO { get; set; }

    public int? intDiasPrecioLiquidacion { get; set; }

    public string? strNombreRepresentante { get; set; }

    public string? strDescripcionEstacion { get; set; }

    public string? strTipoCaracter { get; set; }

    public string? strModalidadCaracter { get; set; }

    public string? strVersionCV { get; set; }

    public string? strObservacionGral { get; set; }

    public string? strClaveIdentificacion { get; set; }

    public string? strUnidadMedida { get; set; }

    public string? strLicenciaSantanderDev { get; set; }

    public string? strLicenciaSantanderProd { get; set; }

    public bool? bitRetoMobil { get; set; }

    public string? strRetoMobilUrl { get; set; }

    public string? strRetoMobilApiKey { get; set; }

    public string? strRetoMobilPublicKey { get; set; }

    public string? strRetoMobilKid { get; set; }

    public string? strCaracterSitio { get; set; }
}
