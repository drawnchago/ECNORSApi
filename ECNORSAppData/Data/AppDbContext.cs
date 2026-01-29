using System;
using System.Collections.Generic;
using ECNORSAppData.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ECNORSAppData.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public virtual DbSet<tblDocumentacion> tblDocumentacion { get; set; }

    public virtual DbSet<AUX_RecepcionesDet> AUX_RecepcionesDets { get; set; }

    public virtual DbSet<AUX_tblLikuitiDetCheque> AUX_tblLikuitiDetCheques { get; set; }

    public virtual DbSet<AUX_tblLikuitiDetPago> AUX_tblLikuitiDetPagos { get; set; }

    public virtual DbSet<AUX_tblLikuitiDetProd> AUX_tblLikuitiDetProds { get; set; }

    public virtual DbSet<AUX_tblLikuitiEnc> AUX_tblLikuitiEncs { get; set; }

    public virtual DbSet<CVArchivoRecepcione> CVArchivoRecepciones { get; set; }

    public virtual DbSet<CVControlArchivo> CVControlArchivos { get; set; }

    public virtual DbSet<CVLog> CVLogs { get; set; }

    public virtual DbSet<CVParametro> CVParametros { get; set; }

    public virtual DbSet<CVRecepcione> CVRecepciones { get; set; }

    public virtual DbSet<CVRecepcionesTmp> CVRecepcionesTmps { get; set; }

    public virtual DbSet<CVVenta> CVVentas { get; set; }

    public virtual DbSet<CVVentasTmp> CVVentasTmps { get; set; }

    public virtual DbSet<CVVentasTmp1> CVVentasTmp1s { get; set; }

    public virtual DbSet<CVVentas_Paso> CVVentas_Pasos { get; set; }

    public virtual DbSet<GNL_octubre2024> GNL_octubre2024s { get; set; }

    public virtual DbSet<PemexCodigo> PemexCodigos { get; set; }

    public virtual DbSet<PemexEnvioArchivo> PemexEnvioArchivos { get; set; }

    public virtual DbSet<PemexTiposArchivo> PemexTiposArchivos { get; set; }

    public virtual DbSet<PemexUsuario> PemexUsuarios { get; set; }

    public virtual DbSet<UAConsolaTotalizadore> UAConsolaTotalizadores { get; set; }

    public virtual DbSet<UA_rel_colecta_desgloce> UA_rel_colecta_desgloces { get; set; }

    public virtual DbSet<UA_rel_desgloce_denominacion> UA_rel_desgloce_denominacions { get; set; }

    public virtual DbSet<UA_tblColecta> UA_tblColectas { get; set; }

    public virtual DbSet<UA_tblDenominaciones_billete> UA_tblDenominaciones_billetes { get; set; }

    public virtual DbSet<UA_tblDenominaciones_moralla> UA_tblDenominaciones_morallas { get; set; }

    public virtual DbSet<UA_tbl_Desgloce_Denominacione> UA_tbl_Desgloce_Denominaciones { get; set; }

    public virtual DbSet<UA_tbl_Detalle_Desgloce_Denominacione> UA_tbl_Detalle_Desgloce_Denominaciones { get; set; }

    public virtual DbSet<flyway_schema_history> flyway_schema_histories { get; set; }

    public virtual DbSet<rel_rol_modulo> rel_rol_modulos { get; set; }

    public virtual DbSet<segacceso> segaccesos { get; set; }

    public virtual DbSet<segusuario> segusuarios { get; set; }

    public virtual DbSet<syscursordat> syscursordats { get; set; }

    public virtual DbSet<syscursordate> syscursordates { get; set; }

    public virtual DbSet<syscursordatp> syscursordatps { get; set; }

    public virtual DbSet<syscursorfar> syscursorfars { get; set; }

    public virtual DbSet<syscursorpar> syscursorpars { get; set; }

    public virtual DbSet<tblAcceso> tblAccesos { get; set; }

    public virtual DbSet<tblAccesosDirecto> tblAccesosDirectos { get; set; }

    public virtual DbSet<tblAccesosGrupo> tblAccesosGrupos { get; set; }

    public virtual DbSet<tblAccione> tblAcciones { get; set; }

    public virtual DbSet<tblAlarmaDispensario> tblAlarmaDispensarios { get; set; }

    public virtual DbSet<tblAlarmaTanque> tblAlarmaTanques { get; set; }

    public virtual DbSet<tblAlmacene> tblAlmacenes { get; set; }

    public virtual DbSet<tblAplicacione> tblAplicaciones { get; set; }

    public virtual DbSet<tblArchivoRecepcionesCV> tblArchivoRecepcionesCVs { get; set; }

    public virtual DbSet<tblArchivosCV> tblArchivosCVs { get; set; }

    public virtual DbSet<tblArchivosVolumetricosRegenerado> tblArchivosVolumetricosRegenerados { get; set; }

    public virtual DbSet<tblArticulosPromocionale> tblArticulosPromocionales { get; set; }

    public virtual DbSet<tblAutoDiagnostico> tblAutoDiagnosticos { get; set; }

    public virtual DbSet<tblAutoriza> tblAutorizas { get; set; }

    public virtual DbSet<tblBackupSchedule> tblBackupSchedules { get; set; }

    public virtual DbSet<tblBanco> tblBancos { get; set; }

    public virtual DbSet<tblBasis> tblBases { get; set; }

    public virtual DbSet<tblBitacora> tblBitacoras { get; set; }

    public virtual DbSet<tblBitacoraAlerta> tblBitacoraAlertas { get; set; }

    public virtual DbSet<tblBitacoraConsola> tblBitacoraConsolas { get; set; }

    public virtual DbSet<tblBitacoraImpresion> tblBitacoraImpresions { get; set; }

    public virtual DbSet<tblBitacoraMensaje> tblBitacoraMensajes { get; set; }

    public virtual DbSet<tblBitacoraTL> tblBitacoraTLs { get; set; }

    public virtual DbSet<tblBitacoraTXCenter> tblBitacoraTXCenters { get; set; }

    public virtual DbSet<tblBitacoraVale> tblBitacoraVales { get; set; }

    public virtual DbSet<tblBitacoraVario> tblBitacoraVarios { get; set; }

    public virtual DbSet<tblBitacora_Duplicada> tblBitacora_Duplicadas { get; set; }

    public virtual DbSet<tblBitacora_Historium> tblBitacora_Historia { get; set; }

    public virtual DbSet<tblBoletosCinepoli> tblBoletosCinepolis { get; set; }

    public virtual DbSet<tblBoletosGOBenefit> tblBoletosGOBenefits { get; set; }

    public virtual DbSet<tblCICAlarmasCategoria> tblCICAlarmasCategorias { get; set; }

    public virtual DbSet<tblCICAlarmasTipo> tblCICAlarmasTipos { get; set; }

    public virtual DbSet<tblCalibracione> tblCalibraciones { get; set; }

    public virtual DbSet<tblCantidadTipoDespacho> tblCantidadTipoDespachos { get; set; }

    public virtual DbSet<tblCargaInicialInventario> tblCargaInicialInventarios { get; set; }

    public virtual DbSet<tblCatEstado> tblCatEstados { get; set; }

    public virtual DbSet<tblCertificadosJSON> tblCertificadosJSONs { get; set; }

    public virtual DbSet<tblCheckSum> tblCheckSums { get; set; }

    public virtual DbSet<tblCinepoli> tblCinepolis { get; set; }

    public virtual DbSet<tblCinepolisBoleto> tblCinepolisBoletos { get; set; }

    public virtual DbSet<tblClientesComercializadorasAfiliada> tblClientesComercializadorasAfiliadas { get; set; }

    public virtual DbSet<tblClientesConsignacion> tblClientesConsignacions { get; set; }

    public virtual DbSet<tblColecta> tblColectas { get; set; }

    public virtual DbSet<tblColectasDetalle> tblColectasDetalles { get; set; }

    public virtual DbSet<tblColectasInicio> tblColectasInicios { get; set; }

    public virtual DbSet<tblComandosConfiguracion> tblComandosConfiguracions { get; set; }

    public virtual DbSet<tblComandosTL> tblComandosTLs { get; set; }

    public virtual DbSet<tblComercializadora> tblComercializadoras { get; set; }

    public virtual DbSet<tblComponente> tblComponentes { get; set; }

    public virtual DbSet<tblConexionesAutorizada> tblConexionesAutorizadas { get; set; }

    public virtual DbSet<tblConfiguracionBanorte> tblConfiguracionBanortes { get; set; }

    public virtual DbSet<tblConfiguracionPuertoTL> tblConfiguracionPuertoTLs { get; set; }

    public virtual DbSet<tblConfiguracionWebService> tblConfiguracionWebServices { get; set; }

    public virtual DbSet<tblConsultasUG> tblConsultasUGs { get; set; }

    public virtual DbSet<tblControlesVolumetrico> tblControlesVolumetricos { get; set; }

    public virtual DbSet<tblCorteSeguridad> tblCorteSeguridads { get; set; }

    public virtual DbSet<tblCorteSeguridadDesgloce> tblCorteSeguridadDesgloces { get; set; }

    public virtual DbSet<tblCorteSeguridadDet> tblCorteSeguridadDets { get; set; }

    public virtual DbSet<tblCortesManuale> tblCortesManuales { get; set; }

    public virtual DbSet<tblCortesReporte> tblCortesReportes { get; set; }

    public virtual DbSet<tblDenominacionesTipoVentum> tblDenominacionesTipoVenta { get; set; }

    public virtual DbSet<tblDictamenDocumento> tblDictamenDocumentos { get; set; }

    public virtual DbSet<tblDictamenesDET> tblDictamenesDETs { get; set; }

    public virtual DbSet<tblDictamenesENC> tblDictamenesENCs { get; set; }

    public virtual DbSet<tblDispensario> tblDispensarios { get; set; }

    public virtual DbSet<tblDispensarioXAlmacen> tblDispensarioXAlmacens { get; set; }

    public virtual DbSet<tblDocumento> tblDocumentos { get; set; }

    public virtual DbSet<tblDocumentosAnexo> tblDocumentosAnexos { get; set; }

    public virtual DbSet<tblDocumentosCV> tblDocumentosCVs { get; set; }

    public virtual DbSet<tblDonativo> tblDonativos { get; set; }

    public virtual DbSet<tblErroresServicio> tblErroresServicios { get; set; }

    public virtual DbSet<tblEstatusApp> tblEstatusApps { get; set; }

    public virtual DbSet<tblEstatusSesion> tblEstatusSesions { get; set; }

    public virtual DbSet<tblExistencia> tblExistencias { get; set; }

    public virtual DbSet<tblExistenciasCV> tblExistenciasCVs { get; set; }

    public virtual DbSet<tblFechasTransmicion> tblFechasTransmicions { get; set; }

    public virtual DbSet<tblFolioLiquidacionXDi> tblFolioLiquidacionXDis { get; set; }

    public virtual DbSet<tblFoliosCorte> tblFoliosCortes { get; set; }

    public virtual DbSet<tblFoliosCorteDi> tblFoliosCorteDis { get; set; }

    public virtual DbSet<tblFoliosReleacionRecepcionesDocumento> tblFoliosReleacionRecepcionesDocumentos { get; set; }

    public virtual DbSet<tblFormasPago> tblFormasPagos { get; set; }

    public virtual DbSet<tblGoBenefit> tblGoBenefits { get; set; }

    public virtual DbSet<tblGoBenefitsAcumulacion> tblGoBenefitsAcumulacions { get; set; }

    public virtual DbSet<tblGrupo> tblGrupos { get; set; }

    public virtual DbSet<tblHorasCV> tblHorasCVs { get; set; }

    public virtual DbSet<tblImpresione> tblImpresiones { get; set; }

    public virtual DbSet<tblInterface> tblInterfaces { get; set; }

    public virtual DbSet<tblInventarioTanques_CV> tblInventarioTanques_CVs { get; set; }

    public virtual DbSet<tblIsla> tblIslas { get; set; }

    public virtual DbSet<tblIslaAlmacen> tblIslaAlmacens { get; set; }

    public virtual DbSet<tblLectorBitacora> tblLectorBitacoras { get; set; }

    public virtual DbSet<tblLiqXDisFormasPago> tblLiqXDisFormasPagos { get; set; }

    public virtual DbSet<tblLiqXDisProducto> tblLiqXDisProductos { get; set; }

    public virtual DbSet<tblLiquidacionDetPago> tblLiquidacionDetPagos { get; set; }

    public virtual DbSet<tblLiquidacionDetPagosAjuste> tblLiquidacionDetPagosAjustes { get; set; }

    public virtual DbSet<tblLiquidacionDetProd> tblLiquidacionDetProds { get; set; }

    public virtual DbSet<tblLiquidacionDetProdAjuste> tblLiquidacionDetProdAjustes { get; set; }

    public virtual DbSet<tblLiquidacionEnc> tblLiquidacionEncs { get; set; }

    public virtual DbSet<tblLiquidacionXDi> tblLiquidacionXDis { get; set; }

    public virtual DbSet<tblListaPropiedade> tblListaPropiedades { get; set; }

    public virtual DbSet<tblLogConsultaUG> tblLogConsultaUGs { get; set; }

    public virtual DbSet<tblManguera> tblMangueras { get; set; }

    public virtual DbSet<tblMedidore> tblMedidores { get; set; }

    public virtual DbSet<tblMedidoresJSON> tblMedidoresJSONs { get; set; }

    public virtual DbSet<tblMensajesApp> tblMensajesApps { get; set; }

    public virtual DbSet<tblMenuPrincipal> tblMenuPrincipals { get; set; }

    public virtual DbSet<tblMenusTPV> tblMenusTPVs { get; set; }

    public virtual DbSet<tblMeta> tblMetas { get; set; }

    public virtual DbSet<tblModulo> tblModulos { get; set; }

    public virtual DbSet<tblModulosUA> tblModulosUAs { get; set; }

    public virtual DbSet<tblMoneda> tblMonedas { get; set; }

    public virtual DbSet<tblMovimientosInv> tblMovimientosInvs { get; set; }

    public virtual DbSet<tblMovimientosInvDet> tblMovimientosInvDets { get; set; }

    public virtual DbSet<tblNexGen> tblNexGens { get; set; }

    public virtual DbSet<tblNotificationsIP> tblNotificationsIPs { get; set; }

    public virtual DbSet<tblPagoGOBenefit> tblPagoGOBenefits { get; set; }

    public virtual DbSet<tblParametro> tblParametros { get; set; }

    public virtual DbSet<tblParametrosServiciosWEB> tblParametrosServiciosWEBs { get; set; }

    public virtual DbSet<tblParametrosTPV> tblParametrosTPVs { get; set; }

    public virtual DbSet<tblPaso> tblPasos { get; set; }

    public virtual DbSet<tblPasosManager> tblPasosManagers { get; set; }

    public virtual DbSet<tblPasosManager_jul14_2025> tblPasosManager_jul14_2025s { get; set; }

    public virtual DbSet<tblPasosManager_mar01_2025> tblPasosManager_mar01_2025s { get; set; }

    public virtual DbSet<tblPemexConfiguracion> tblPemexConfiguracions { get; set; }

    public virtual DbSet<tblPermiso> tblPermisos { get; set; }

    public virtual DbSet<tblPermisosObjeto> tblPermisosObjetos { get; set; }

    public virtual DbSet<tblPolizaLiquidacion> tblPolizaLiquidacions { get; set; }

    public virtual DbSet<tblPreciosProgramado> tblPreciosProgramados { get; set; }

    public virtual DbSet<tblPreciosProgramadosAplicado> tblPreciosProgramadosAplicados { get; set; }

    public virtual DbSet<tblPresentacione> tblPresentaciones { get; set; }

    public virtual DbSet<tblPresupuestoADLUB_Estacion> tblPresupuestoADLUB_Estacions { get; set; }

    public virtual DbSet<tblProceso> tblProcesos { get; set; }

    public virtual DbSet<tblProcesoPaso> tblProcesoPasos { get; set; }

    public virtual DbSet<tblProcesoPasoManager> tblProcesoPasoManagers { get; set; }

    public virtual DbSet<tblProcesoPasoManager_respaldo> tblProcesoPasoManager_respaldos { get; set; }

    public virtual DbSet<tblProducto> tblProductos { get; set; }

    public virtual DbSet<tblProductosCV> tblProductosCVs { get; set; }

    public virtual DbSet<tblProductosHist> tblProductosHists { get; set; }

    public virtual DbSet<tblProductos_BajaInventario> tblProductos_BajaInventarios { get; set; }

    public virtual DbSet<tblPromocione> tblPromociones { get; set; }

    public virtual DbSet<tblPromocionesDescuento> tblPromocionesDescuentos { get; set; }

    public virtual DbSet<tblPropiedaesTankAgent> tblPropiedaesTankAgents { get; set; }

    public virtual DbSet<tblProveedore> tblProveedores { get; set; }

    public virtual DbSet<tblProveedoresCRE> tblProveedoresCREs { get; set; }

    public virtual DbSet<tblProveedoresCV> tblProveedoresCVs { get; set; }

    public virtual DbSet<tblRecepcionDictamene> tblRecepcionDictamenes { get; set; }

    public virtual DbSet<tblRecepcionesCV> tblRecepcionesCVs { get; set; }

    public virtual DbSet<tblRecepcionesCVXConfirmar> tblRecepcionesCVXConfirmars { get; set; }

    public virtual DbSet<tblRecepcionesCV_eliminado> tblRecepcionesCV_eliminados { get; set; }

    public virtual DbSet<tblRecepcionesDet> tblRecepcionesDets { get; set; }

    public virtual DbSet<tblRecepcionesEnc> tblRecepcionesEncs { get; set; }

    public virtual DbSet<tblRegistroEjecucionActualizacion> tblRegistroEjecucionActualizacions { get; set; }

    public virtual DbSet<tblRelacionDispensarioTanque> tblRelacionDispensarioTanques { get; set; }

    public virtual DbSet<tblRelacionTPVIsla> tblRelacionTPVIslas { get; set; }

    public virtual DbSet<tblReporte> tblReportes { get; set; }

    public virtual DbSet<tblRequisitosApp> tblRequisitosApps { get; set; }

    public virtual DbSet<tblRolUsuario> tblRolUsuarios { get; set; }

    public virtual DbSet<tblRole> tblRoles { get; set; }

    public virtual DbSet<tblSeguridadModulo> tblSeguridadModulos { get; set; }

    public virtual DbSet<tblSeguridadNivele> tblSeguridadNiveles { get; set; }

    public virtual DbSet<tblSesione> tblSesiones { get; set; }

    public virtual DbSet<tblSesiones_Hist> tblSesiones_Hists { get; set; }

    public virtual DbSet<tblTPV> tblTPVs { get; set; }

    public virtual DbSet<tblTPVMenu> tblTPVMenus { get; set; }

    public virtual DbSet<tblTPVXDispensario> tblTPVXDispensarios { get; set; }

    public virtual DbSet<tblTankVirtualGlobal> tblTankVirtualGlobals { get; set; }

    public virtual DbSet<tblTanque> tblTanques { get; set; }

    public virtual DbSet<tblTanques_CV> tblTanques_CVs { get; set; }

    public virtual DbSet<tblTanques_Hist> tblTanques_Hists { get; set; }

    public virtual DbSet<tblTerminale> tblTerminales { get; set; }

    public virtual DbSet<tblTerminalesBancaria> tblTerminalesBancarias { get; set; }

    public virtual DbSet<tblTiemposCV> tblTiemposCVs { get; set; }

    public virtual DbSet<tblTipoComponente> tblTipoComponentes { get; set; }

    public virtual DbSet<tblTipoControl> tblTipoControls { get; set; }

    public virtual DbSet<tblTipoDespacho> tblTipoDespachos { get; set; }

    public virtual DbSet<tblTipoDispositivo> tblTipoDispositivos { get; set; }

    public virtual DbSet<tblTipoMedicion> tblTipoMedicions { get; set; }

    public virtual DbSet<tblTipoProcesoE> tblTipoProcesoEs { get; set; }

    public virtual DbSet<tblTipoVentana> tblTipoVentanas { get; set; }

    public virtual DbSet<tblTiposAlmacen> tblTiposAlmacens { get; set; }

    public virtual DbSet<tblTiposArchivo> tblTiposArchivos { get; set; }

    public virtual DbSet<tblTiposDocumento> tblTiposDocumentos { get; set; }

    public virtual DbSet<tblTiposDocumentoLiq> tblTiposDocumentoLiqs { get; set; }

    public virtual DbSet<tblTiposMedidore> tblTiposMedidores { get; set; }

    public virtual DbSet<tblTiposMovimientoInv> tblTiposMovimientoInvs { get; set; }

    public virtual DbSet<tblTiposPago> tblTiposPagos { get; set; }

    public virtual DbSet<tblTiposProducto> tblTiposProductos { get; set; }

    public virtual DbSet<tblTiposServicio> tblTiposServicios { get; set; }

    public virtual DbSet<tblTiposTransaccion> tblTiposTransaccions { get; set; }

    public virtual DbSet<tblTiposVentum> tblTiposVenta { get; set; }

    public virtual DbSet<tblTokenUniversal> tblTokenUniversals { get; set; }

    public virtual DbSet<tblTotalizadore> tblTotalizadores { get; set; }

    public virtual DbSet<tblTotalizadoresManuale> tblTotalizadoresManuales { get; set; }

    public virtual DbSet<tblTotalizadores_Copium> tblTotalizadores_Copia { get; set; }

    public virtual DbSet<tblTotalizadorxDi> tblTotalizadorxDis { get; set; }

    public virtual DbSet<tblTranMonedero> tblTranMonederos { get; set; }

    public virtual DbSet<tblTranRecepcionCV> tblTranRecepcionCVs { get; set; }

    public virtual DbSet<tblTransaccione> tblTransacciones { get; set; }

    public virtual DbSet<tblTransaccionesBancaria> tblTransaccionesBancarias { get; set; }

    public virtual DbSet<tblTransaccionesConsola> tblTransaccionesConsolas { get; set; }

    public virtual DbSet<tblTransaccionesDetV2> tblTransaccionesDetV2s { get; set; }

    public virtual DbSet<tblTransaccionesDetV2_Historium> tblTransaccionesDetV2_Historia { get; set; }

    public virtual DbSet<tblTransaccionesDet_FormaPago> tblTransaccionesDet_FormaPagos { get; set; }

    public virtual DbSet<tblTransaccionesDolare> tblTransaccionesDolares { get; set; }

    public virtual DbSet<tblTransaccionesPinPad> tblTransaccionesPinPads { get; set; }

    public virtual DbSet<tblTransaccionesServicio> tblTransaccionesServicios { get; set; }

    public virtual DbSet<tblTransaccionesVario> tblTransaccionesVarios { get; set; }

    public virtual DbSet<tblTransaccionesVarios_Detalle> tblTransaccionesVarios_Detalles { get; set; }

    public virtual DbSet<tblTransacciones_Eliminado> tblTransacciones_Eliminados { get; set; }

    public virtual DbSet<tblTransacciones_Historium> tblTransacciones_Historia { get; set; }

    public virtual DbSet<tblTransacciones_NOENVIADA> tblTransacciones_NOENVIADAs { get; set; }

    public virtual DbSet<tblTransacciones_Promocione> tblTransacciones_Promociones { get; set; }

    public virtual DbSet<tblTransportesCV> tblTransportesCVs { get; set; }

    public virtual DbSet<tblTurno> tblTurnos { get; set; }

    public virtual DbSet<tblUATransaccionUUID> tblUATransaccionUUIDs { get; set; }

    public virtual DbSet<tblUAV2_ConexionEndpoint> tblUAV2_ConexionEndpoints { get; set; }

    public virtual DbSet<tblUAV2_ErrorLog> tblUAV2_ErrorLogs { get; set; }

    public virtual DbSet<tblUAV2_EstatusDispensario> tblUAV2_EstatusDispensarios { get; set; }

    public virtual DbSet<tblUAV2_GoBenefit> tblUAV2_GoBenefits { get; set; }

    public virtual DbSet<tblUAV2_GoBenefitsAppLog> tblUAV2_GoBenefitsAppLogs { get; set; }

    public virtual DbSet<tblUAV2_Opcion> tblUAV2_Opcions { get; set; }

    public virtual DbSet<tblUAV2_PagoTerminal> tblUAV2_PagoTerminals { get; set; }

    public virtual DbSet<tblUAV2_RetoMobil> tblUAV2_RetoMobils { get; set; }

    public virtual DbSet<tblUAV2_Sesione> tblUAV2_Sesiones { get; set; }

    public virtual DbSet<tblUAV2_SolicitudAutorizacion> tblUAV2_SolicitudAutorizacions { get; set; }

    public virtual DbSet<tblUAV2_TokaPago> tblUAV2_TokaPagos { get; set; }

    public virtual DbSet<tblUAV2_WSHelperLog> tblUAV2_WSHelperLogs { get; set; }

    public virtual DbSet<tblUltimosPassword> tblUltimosPasswords { get; set; }

    public virtual DbSet<tblUsuario> tblUsuarios { get; set; }

    public virtual DbSet<tblUsuarioIsla> tblUsuarioIslas { get; set; }

    public virtual DbSet<tblUsuarioIslaProgramado> tblUsuarioIslaProgramados { get; set; }

    public virtual DbSet<tblUsuariosDi> tblUsuariosDis { get; set; }

    public virtual DbSet<tblUsuariosGrupo> tblUsuariosGrupos { get; set; }

    public virtual DbSet<tblUsuariosStatus> tblUsuariosStatuses { get; set; }

    public virtual DbSet<tblVentasCV> tblVentasCVs { get; set; }

    public virtual DbSet<tblWSSEP> tblWSSEPs { get; set; }

    public virtual DbSet<tblWSSEp_Transaccione> tblWSSEp_Transacciones { get; set; }

    public virtual DbSet<tbl_CP_PreciosProgramado> tbl_CP_PreciosProgramados { get; set; }

    public virtual DbSet<tblprocesopasomanager_jul14_2025> tblprocesopasomanager_jul14_2025s { get; set; }

    public virtual DbSet<tblprocesopasomanager_mar01_2025> tblprocesopasomanager_mar01_2025s { get; set; }

    public virtual DbSet<tblpromociones_detalle> tblpromociones_detalles { get; set; }

    public virtual DbSet<tblserviciosweb> tblservicioswebs { get; set; }

    public virtual DbSet<tbltransacciones_ERROR> tbltransacciones_ERRORs { get; set; }

    public virtual DbSet<tbltransacciones_eliminada> tbltransacciones_eliminadas { get; set; }

    public virtual DbSet<tmpRecepcionesCV> tmpRecepcionesCVs { get; set; }

    public virtual DbSet<tmpVentas1CV> tmpVentas1CVs { get; set; }

    public virtual DbSet<tmpVentasCV> tmpVentasCVs { get; set; }

    public virtual DbSet<viwCorte_CorteAnteriorLiquidado> viwCorte_CorteAnteriorLiquidados { get; set; }

    public virtual DbSet<viwLiquidacion_CapturaManualTransacciones_Producto> viwLiquidacion_CapturaManualTransacciones_Productos { get; set; }

    public virtual DbSet<viwLiquidacion_CapturaManualTransacciones_TPV> viwLiquidacion_CapturaManualTransacciones_TPVs { get; set; }

    public virtual DbSet<viwLiquidacion_CapturaManualTransacciones_Transaccione> viwLiquidacion_CapturaManualTransacciones_Transacciones { get; set; }

    public virtual DbSet<viwLiquidacion_CapturaManualTransacciones_Usuario> viwLiquidacion_CapturaManualTransacciones_Usuarios { get; set; }

    public virtual DbSet<viwLiquidacion_CortesXLiquidar> viwLiquidacion_CortesXLiquidars { get; set; }

    public virtual DbSet<viwLiquidacion_DispensariosXCortar> viwLiquidacion_DispensariosXCortars { get; set; }

    public virtual DbSet<viwLiquidacion_Inventarios_Detalle> viwLiquidacion_Inventarios_Detalles { get; set; }

    public virtual DbSet<viwLiquidacion_LiquidacionesXFecha> viwLiquidacion_LiquidacionesXFechas { get; set; }

    public virtual DbSet<viwLiquidacion_MovimientosInventario> viwLiquidacion_MovimientosInventarios { get; set; }

    public virtual DbSet<viwLiquidacion_MovimientosInventario_Ajuste> viwLiquidacion_MovimientosInventario_Ajustes { get; set; }

    public virtual DbSet<viwLiquidacion_Producto> viwLiquidacion_Productos { get; set; }

    public virtual DbSet<viwLiquidacion_Productos_AditYLub> viwLiquidacion_Productos_AditYLubs { get; set; }

    public virtual DbSet<viwLiquidacion_TotalTotalizadoresXDespachador> viwLiquidacion_TotalTotalizadoresXDespachadors { get; set; }

    public virtual DbSet<viwLiquidacion_TotalTotalizadoresXIsla> viwLiquidacion_TotalTotalizadoresXIslas { get; set; }

    public virtual DbSet<viwLiquidacion_TotalTransaccione> viwLiquidacion_TotalTransacciones { get; set; }

    public virtual DbSet<viwLiquidacion_TotalTransaccionesXDespachador> viwLiquidacion_TotalTransaccionesXDespachadors { get; set; }

    public virtual DbSet<viwLiquidacion_TotalTransaccionesXDespachador_Manual> viwLiquidacion_TotalTransaccionesXDespachador_Manuals { get; set; }

    public virtual DbSet<viwLiquidacion_TotalTransaccionesXDespachador_Transaccione> viwLiquidacion_TotalTransaccionesXDespachador_Transacciones { get; set; }

    public virtual DbSet<viwLiquidacion_TotalTransaccionesXDespachador_TransaccionesVario> viwLiquidacion_TotalTransaccionesXDespachador_TransaccionesVarios { get; set; }

    public virtual DbSet<viwLiquidacion_TotalTransaccionesXIsla> viwLiquidacion_TotalTransaccionesXIslas { get; set; }

    public virtual DbSet<viwLiquidacion_TotalXLiquidar> viwLiquidacion_TotalXLiquidars { get; set; }

    public virtual DbSet<viwLiquidacion_TotalesXFecha> viwLiquidacion_TotalesXFechas { get; set; }

    public virtual DbSet<viwLiquidacion_Totalizadore> viwLiquidacion_Totalizadores { get; set; }

    public virtual DbSet<viwLiquidacion_UA_TotalXLiquidar> viwLiquidacion_UA_TotalXLiquidars { get; set; }

    public virtual DbSet<viwLiquidacion_XCorte> viwLiquidacion_XCortes { get; set; }

    public virtual DbSet<viwLiquidacion_tblLiquidacionDetPago> viwLiquidacion_tblLiquidacionDetPagos { get; set; }

    public virtual DbSet<viwLiquidacion_tblLiquidacionDetPagosAjuste> viwLiquidacion_tblLiquidacionDetPagosAjustes { get; set; }

    public virtual DbSet<viwLiquidacion_tblLiquidacionDetPagos_SEL> viwLiquidacion_tblLiquidacionDetPagos_SELs { get; set; }

    public virtual DbSet<viwLiquidacion_tblLiquidacionDetPagos_TOTAL> viwLiquidacion_tblLiquidacionDetPagos_TOTALs { get; set; }

    public virtual DbSet<viwLiquidacion_tblLiquidacionDetPagos_UNION> viwLiquidacion_tblLiquidacionDetPagos_UNIONs { get; set; }

    public virtual DbSet<viwLiquidacion_tblLiquidacionDetProd> viwLiquidacion_tblLiquidacionDetProds { get; set; }

    public virtual DbSet<viwLiquidacion_tblLiquidacionDetProdAjuste> viwLiquidacion_tblLiquidacionDetProdAjustes { get; set; }

    public virtual DbSet<viwLiquidacion_tblLiquidacionDetProd_SEL> viwLiquidacion_tblLiquidacionDetProd_SELs { get; set; }

    public virtual DbSet<viwLiquidacion_tblLiquidacionDetProd_TOTAL> viwLiquidacion_tblLiquidacionDetProd_TOTALs { get; set; }

    public virtual DbSet<viwLiquidacion_tblLiquidacionDetProd_UAStock_SEL> viwLiquidacion_tblLiquidacionDetProd_UAStock_SELs { get; set; }

    public virtual DbSet<viwLiquidacion_tblLiquidacionDetProd_UNION> viwLiquidacion_tblLiquidacionDetProd_UNIONs { get; set; }

    public virtual DbSet<viwLiquidacion_tblLiquidacionEnc> viwLiquidacion_tblLiquidacionEncs { get; set; }

    public virtual DbSet<viwTPV_Dispensario> viwTPV_Dispensarios { get; set; }

    public virtual DbSet<viwTPV_Producto> viwTPV_Productos { get; set; }

    public virtual DbSet<viwTPV_UsuariosActivo> viwTPV_UsuariosActivos { get; set; }

    public virtual DbSet<viw_CICAlarma> viw_CICAlarmas { get; set; }

    public virtual DbSet<viw_Liquidacion_Rep> viw_Liquidacion_Reps { get; set; }

    public virtual DbSet<viw_Liquidacion_Transaccione> viw_Liquidacion_Transacciones { get; set; }

    public virtual DbSet<viw_NombreArchivo> viw_NombreArchivos { get; set; }

    public virtual DbSet<viw_TanquesProducto> viw_TanquesProductos { get; set; }

    public virtual DbSet<viw_TransactionsAllRelation> viw_TransactionsAllRelations { get; set; }

    public virtual DbSet<vwCentralizacion_tblTransaccione> vwCentralizacion_tblTransacciones { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<AUX_RecepcionesDet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AUX_RecepcionesDet");

            entity.Property(e => e.strDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strTipoProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AUX_tblLikuitiDetCheque>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.strBanco)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strCuenta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strFolioDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AUX_tblLikuitiDetPago>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.dblImporteTotal).HasComputedColumnSql("([dblTipoCambioMXP]*[dblImporte])", false);
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AUX_tblLikuitiDetProd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AUX_tblLikuitiDetProd");

            entity.Property(e => e.strProducto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strTipoProducto)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AUX_tblLikuitiEnc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AUX_tblLikuitiEnc");

            entity.Property(e => e.datFechaCaptura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.datFechaLiquidacion).HasColumnType("datetime");
            entity.Property(e => e.strDespachadores)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.strNombreUsuario)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.strPCCaptura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strUsuarioCaptura)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CVArchivoRecepcione>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DETALLE)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FECHAHORAGENERADO)
                .HasMaxLength(22)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CVControlArchivo>(entity =>
        {
            entity.HasKey(e => new { e.Archivo, e.EstacionID }).HasName("PK_CVRecolector");

            entity.Property(e => e.Archivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoRespuesta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Destino)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Detalles)
                .HasMaxLength(6000)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaArchivo).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaRespuesta).HasColumnType("smalldatetime");
            entity.Property(e => e.Origen)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CVLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CVLog");

            entity.Property(e => e.Aplicacion)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Detalles)
                .HasMaxLength(6000)
                .IsUnicode(false);
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())", "DF_CVLog_Fecha")
                .HasColumnType("datetime");
            entity.Property(e => e.Mensaje)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.MensajeID).HasDefaultValueSql("(newid())", "DF_CVLog_MensajeID");
            entity.Property(e => e.Origen)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Proceso)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CVParametro>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<CVRecepcione>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.bitCapturado).HasDefaultValue(false, "DF_CVRecepciones_bitCapturado");
            entity.Property(e => e.datFechaAlta).HasColumnType("datetime");
            entity.Property(e => e.datFechaHoraFinal).HasColumnType("datetime");
            entity.Property(e => e.datFechaHoraInicial).HasColumnType("datetime");
            entity.Property(e => e.intFolioLote).HasDefaultValue(0L);
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CVRecepcionesTmp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CVRecepcionesTmp");

            entity.Property(e => e.FECHAHORAGNAARC)
                .HasMaxLength(22)
                .IsUnicode(false);
            entity.Property(e => e.FechaDocto)
                .HasMaxLength(22)
                .IsUnicode(false);
            entity.Property(e => e.FechaRecepcion)
                .HasMaxLength(22)
                .IsUnicode(false);
            entity.Property(e => e.FolioDocto)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.RFC)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.SIIC)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tanque)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Temperatura).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Terminal)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocto)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TipoRegistro)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Vehiculo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.VolumenDocto).HasColumnType("decimal(13, 3)");
            entity.Property(e => e.VolumenFinal).HasColumnType("decimal(13, 3)");
            entity.Property(e => e.VolumenInicial).HasColumnType("decimal(13, 3)");
            entity.Property(e => e.VolumenRecepcion).HasColumnType("decimal(13, 3)");
        });

        modelBuilder.Entity<CVVenta>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DETALLE)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FECHAHORAGENERADO)
                .HasMaxLength(22)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CVVentasTmp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CVVentasTmp");

            entity.Property(e => e.Cabecera)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.FECHAHORAGNAARC)
                .HasMaxLength(22)
                .IsUnicode(false);
            entity.Property(e => e.FechaTransaccion)
                .HasMaxLength(22)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.RFC)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.SIIC)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Volumen)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(13, 3)");
            entity.Property(e => e.dblImporte)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(13, 3)");
            entity.Property(e => e.dblPrecioUnitario)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(7, 3)");
            entity.Property(e => e.intDispensario)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.intManguera)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CVVentasTmp1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CVVentasTmp1");

            entity.Property(e => e.Cabecera)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.FECHAHORAGNAARC)
                .HasMaxLength(22)
                .IsUnicode(false);
            entity.Property(e => e.FechaTransaccion)
                .HasMaxLength(22)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.RFC)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.SIIC)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Volumen)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(13, 3)");
            entity.Property(e => e.dblImporte)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(13, 3)");
            entity.Property(e => e.dblPrecioUnitario)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(7, 3)");
            entity.Property(e => e.intDispensario)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.intManguera)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CVVentas_Paso>(entity =>
        {
            entity.HasKey(e => new { e.strFecha, e.intTransaccion, e.strProducto });

            entity.ToTable("CVVentas_Paso");

            entity.Property(e => e.strFecha)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.strProducto)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.decImporte).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.decPrecio).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.decVolumen).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.strLineaCV)
                .HasMaxLength(500)
                .IsFixedLength();
        });

        modelBuilder.Entity<GNL_octubre2024>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GNL_octubre2024");

            entity.Property(e => e.EESS).HasMaxLength(255);
            entity.Property(e => e.F13).HasMaxLength(255);
            entity.Property(e => e._base)
                .HasMaxLength(255)
                .HasColumnName("base");
            entity.Property(e => e.fechahora).HasColumnType("datetime");
            entity.Property(e => e.inporte_acumulado).HasColumnName("inporte acumulado");
        });

        modelBuilder.Entity<PemexCodigo>(entity =>
        {
            entity.HasKey(e => e.CodigoPemex)
                .HasName("PK_PEMEXCODIGOS")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.Property(e => e.CodigoPemex).ValueGeneratedNever();
            entity.Property(e => e.DescripcionCorta)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionLarga)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PemexEnvioArchivo>(entity =>
        {
            entity.HasKey(e => new { e.TipoArchivo, e.NumeroEstacion, e.NumeroLote })
                .HasName("PK_PEMEXENVIOARCHIVOS")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.HasIndex(e => e.CodigoPemex, "PemexCodigos_PemexEnvioArchivos_FK").HasFillFactor(90);

            entity.HasIndex(e => e.TipoArchivo, "PemexTiposArchivos_PemexEnvioArchivos_FK").HasFillFactor(90);

            entity.Property(e => e.Archivo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ArchivoCheckSum)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.ArchivoCifrado)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FechaHoraCifrado).HasColumnType("datetime");
            entity.Property(e => e.FechaHoraCodigo).HasColumnType("datetime");
            entity.Property(e => e.FechaHoraCreacion).HasColumnType("datetime");

            entity.HasOne(d => d.CodigoPemexNavigation).WithMany(p => p.PemexEnvioArchivos)
                .HasForeignKey(d => d.CodigoPemex)
                .HasConstraintName("FK_PEMEXENV_PEMEXCODI_PEMEXCOD");

            entity.HasOne(d => d.TipoArchivoNavigation).WithMany(p => p.PemexEnvioArchivos)
                .HasForeignKey(d => d.TipoArchivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PEMEXENV_PEMEXTIPO_PEMEXTIP");
        });

        modelBuilder.Entity<PemexTiposArchivo>(entity =>
        {
            entity.HasKey(e => e.TipoArchivo)
                .HasName("PK_PEMEXTIPOSARCHIVO")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("PemexTiposArchivo");

            entity.Property(e => e.TipoArchivo).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionCorta)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PemexUsuario>(entity =>
        {
            entity.HasKey(e => e.Username)
                .HasName("PK_PEMEXUSUARIOS")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UAConsolaTotalizadore>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__UAConsol__3214EC278A551FA7");

            entity.Property(e => e.Dispensario).HasMaxLength(50);
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IdentificadorTotalizador).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Producto).HasMaxLength(50);
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<UA_rel_colecta_desgloce>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UA_rel_colecta_desgloce");
        });

        modelBuilder.Entity<UA_rel_desgloce_denominacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UA_rel_desgloce_denominacion");

            entity.Property(e => e.tipo)
                .HasMaxLength(1)
                .IsFixedLength();
        });

        modelBuilder.Entity<UA_tblColecta>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFecha).HasColumnType("datetime");
            entity.Property(e => e.datFechaAlta).HasColumnType("datetime");
            entity.Property(e => e.dblFiliales).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.dblMonto).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.dblPropios).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.idColecta).ValueGeneratedOnAdd();
            entity.Property(e => e.intFolioCorte).HasMaxLength(50);
            entity.Property(e => e.strDespachador).HasMaxLength(50);
            entity.Property(e => e.strMaquinaAlta).HasMaxLength(50);
        });

        modelBuilder.Entity<UA_tblDenominaciones_billete>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.idDenominacion).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<UA_tblDenominaciones_moralla>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UA_tblDenominaciones_moralla");

            entity.Property(e => e.idDenominacion).ValueGeneratedOnAdd();
            entity.Property(e => e.intImporte).HasColumnType("decimal(5, 2)");
        });

        modelBuilder.Entity<UA_tbl_Desgloce_Denominacione>(entity =>
        {
            entity.HasKey(e => e.intID);

            entity.Property(e => e.datFecha).HasColumnType("datetime");
            entity.Property(e => e.datFechaModif).HasColumnType("datetime");
            entity.Property(e => e.datfechaAlta).HasColumnType("datetime");
            entity.Property(e => e.dblMonto).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.strMaquinaAlta).HasMaxLength(50);
            entity.Property(e => e.strMaquinaModif).HasMaxLength(50);
            entity.Property(e => e.strNoBolsa).HasMaxLength(50);
            entity.Property(e => e.strTurno).HasMaxLength(50);
            entity.Property(e => e.strUsuarioAlta).HasMaxLength(50);
            entity.Property(e => e.strUsuarioModif).HasMaxLength(50);
        });

        modelBuilder.Entity<UA_tbl_Detalle_Desgloce_Denominacione>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.dblCantidad).HasColumnType("decimal(14, 2)");
            entity.Property(e => e.dblDenominacion).HasColumnType("decimal(14, 2)");
            entity.Property(e => e.dblTotal).HasColumnType("decimal(14, 2)");
            entity.Property(e => e.strTipo).HasMaxLength(50);
        });

        modelBuilder.Entity<flyway_schema_history>(entity =>
        {
            entity.HasKey(e => e.installed_rank).HasName("flyway_schema_history_pk");

            entity.ToTable("flyway_schema_history");

            entity.HasIndex(e => e.success, "flyway_schema_history_s_idx");

            entity.Property(e => e.installed_rank).ValueGeneratedNever();
            entity.Property(e => e.description).HasMaxLength(200);
            entity.Property(e => e.installed_by).HasMaxLength(100);
            entity.Property(e => e.installed_on)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.script).HasMaxLength(1000);
            entity.Property(e => e.type).HasMaxLength(20);
            entity.Property(e => e.version).HasMaxLength(50);
        });

        modelBuilder.Entity<rel_rol_modulo>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<segacceso>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.strmodulo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strprograma)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strusuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<segusuario>(entity =>
        {
            entity.HasKey(e => e.strUsuario).HasFillFactor(90);

            entity.Property(e => e.strUsuario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strFolio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strNombreCompleto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPuerto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<syscursordat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("syscursordat");

            entity.Property(e => e.lvalue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AI");
            entity.Property(e => e.property)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AI");
            entity.Property(e => e.uvalue)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_CI_AI");
            entity.Property(e => e.value)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AI");
        });

        modelBuilder.Entity<syscursordate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("syscursordate");

            entity.Property(e => e.lvalue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AI");
            entity.Property(e => e.property)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AI");
            entity.Property(e => e.value)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AI");
        });

        modelBuilder.Entity<syscursordatp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("syscursordatp");

            entity.Property(e => e.lvalue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AI");
            entity.Property(e => e.property)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AI");
            entity.Property(e => e.value)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AI");
        });

        modelBuilder.Entity<syscursorfar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("syscursorfar");

            entity.Property(e => e.id)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AI");
            entity.Property(e => e.lvalue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AI");
            entity.Property(e => e.objectid)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AI");
            entity.Property(e => e.rlvalue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AI");
            entity.Property(e => e.rvalue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AI");
            entity.Property(e => e.strat)
                .HasMaxLength(64)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AI");
            entity.Property(e => e.value)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AI");
        });

        modelBuilder.Entity<syscursorpar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("syscursorpar");
        });

        modelBuilder.Entity<tblAcceso>(entity =>
        {
            entity.HasKey(e => new { e.intAcceso, e.strPrograma })
                .HasName("PK_tblAccesos_1")
                .HasFillFactor(90);

            entity.Property(e => e.strPrograma)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblAccesosDirecto>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.strDescripcion).HasMaxLength(50);
            entity.Property(e => e.strImagen).HasMaxLength(50);
        });

        modelBuilder.Entity<tblAccesosGrupo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblAccesosGrupo");

            entity.Property(e => e.intAcceso)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.intGrupo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<tblAccione>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFechaHora).HasColumnType("datetime");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strAccion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strMaquina)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPrograma)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strUsuario)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblAlarmaDispensario>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFechaHora).HasColumnType("datetime");
            entity.Property(e => e.strEstatus)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.strGenerado)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblAlarmaTanque>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFechaHora).HasColumnType("datetime");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strEstatus)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.strGenerado)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblAlmacene>(entity =>
        {
            entity.HasKey(e => e.intAlmacen).HasFillFactor(90);

            entity.Property(e => e.intAlmacen).ValueGeneratedNever();
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.intTipoAlmacenNavigation).WithMany(p => p.tblAlmacenes)
                .HasForeignKey(d => d.intTipoAlmacen)
                .HasConstraintName("FK_tblAlmacenes_tblTiposAlmacen");
        });

        modelBuilder.Entity<tblAplicacione>(entity =>
        {
            entity.HasKey(e => e.intApp).HasFillFactor(90);

            entity.Property(e => e.intApp).ValueGeneratedNever();
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strDescripcion).HasMaxLength(255);
            entity.Property(e => e.strMD5).HasMaxLength(255);
            entity.Property(e => e.strNombre).HasMaxLength(50);
            entity.Property(e => e.strRutaArchivo).HasMaxLength(255);
        });

        modelBuilder.Entity<tblArchivoRecepcionesCV>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblArchivoRecepcionesCV");

            entity.Property(e => e.DETALLE)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FECHAHORAGENERADO)
                .HasMaxLength(22)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblArchivosCV>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblArchivosCV");

            entity.Property(e => e.byteArchivo).HasColumnType("image");
            entity.Property(e => e.datFechaAlta).HasColumnType("datetime");
            entity.Property(e => e.strFecha)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.strNombreArchivo).HasMaxLength(510);
        });

        modelBuilder.Entity<tblArchivosVolumetricosRegenerado>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ExisteArchivo)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ExisteBD)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre_Buscado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TienesDatos)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblArticulosPromocionale>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strCodigoBarrasProducto).IsUnicode(false);
            entity.Property(e => e.strCodigoPromocional).IsUnicode(false);
        });

        modelBuilder.Entity<tblAutoDiagnostico>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblAutoDiagnostico");

            entity.Property(e => e.datFechaUltimaConsulta).HasColumnType("datetime");
        });

        modelBuilder.Entity<tblAutoriza>(entity =>
        {
            entity.HasKey(e => e.Clave)
                .HasName("PK__tblAutoriza__3469B275")
                .HasFillFactor(90);

            entity.ToTable("tblAutoriza");

            entity.Property(e => e.Clave).ValueGeneratedNever();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblBackupSchedule>(entity =>
        {
            entity.HasKey(e => e.intID).HasName("PK__tblBacku__11B67932D9E398D6");

            entity.ToTable("tblBackupSchedule");

            entity.Property(e => e.created_at)
                .HasDefaultValueSql("(getdate())", "DF_tblBackupSchedule_create_at")
                .HasColumnType("datetime");
            entity.Property(e => e.created_by)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasDefaultValue("User", "DF_tblBackupSchedule_create_by");
            entity.Property(e => e.datEndDate)
                .HasComment("si tiene fin de operación ")
                .HasDefaultValueSql("(NULL)", "DF_tblBackupSchedule_datEndDate")
                .HasColumnType("datetime");
            entity.Property(e => e.datStartDate)
                .HasComment("fecha de inicio del backup")
                .HasDefaultValueSql("(getdate())", "DF_tblBackupSchedule_datStartDate")
                .HasColumnType("datetime");
            entity.Property(e => e.intInterval).HasComment("intervalo entre cada iteración ");
            entity.Property(e => e.intStatus).HasDefaultValue(1, "DF_tblBackupSchedule_intStatus");
            entity.Property(e => e.strDB)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.strDescription).HasColumnType("text");
            entity.Property(e => e.strHost)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.strPath)
                .HasMaxLength(512)
                .IsUnicode(false);
            entity.Property(e => e.strScheduleType)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasComment("1=OneTime|2=Daily|3=Weekly|4=Monthly");
            entity.Property(e => e.strUser)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.strWeeksday)
                .HasMaxLength(13)
                .IsFixedLength()
                .HasComment("L,M,M,J,V,S,D")
                .HasDefaultValue("0,0,0,0,0,0,0", "DF_tblBackupSchedule_strWeeksday");
            entity.Property(e => e.updated_at).HasColumnType("datetime");
        });

        modelBuilder.Entity<tblBanco>(entity =>
        {
            entity.HasKey(e => e.intBanco).HasFillFactor(90);

            entity.Property(e => e.intBanco).ValueGeneratedNever();
            entity.Property(e => e.strNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strNombreCorto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblBasis>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.strBaseCentral)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strBaseLocal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPasswordCentral)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPasswordLocal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strServidorCentral)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strServidorLocal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strUsuarioCentral)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strUsuarioLocal)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblBitacora>(entity =>
        {
            entity.HasKey(e => e.intSecuencia)
                .HasName("PK__tblBitacora__03543F67")
                .HasFillFactor(90);

            entity.ToTable("tblBitacora");

            entity.HasIndex(e => e.intSecuencia, "IDX_Secuencia");

            entity.HasIndex(e => e.intDispensario, "idx_tblBitacora_Dispensario");

            entity.Property(e => e.intSecuencia).ValueGeneratedNever();
            entity.Property(e => e.bitCerrada).HasDefaultValue(false, "DF_tblBitacora_bitCerrada");
            entity.Property(e => e.datFechaCerrada).HasColumnType("datetime");
            entity.Property(e => e.datFechaHora).HasColumnType("datetime");
            entity.Property(e => e.intId).ValueGeneratedOnAdd();
            entity.Property(e => e.strBandaMagnetica)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strCliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strObservaciones).HasMaxLength(4000);
            entity.Property(e => e.strOdometro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strOdometroAnterior)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPedidoVentaJSON).IsUnicode(false);
            entity.Property(e => e.strPie1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strTarjeta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strTipoTransaccion)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.strTotalizador)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strTotalizadorFinalOriginal).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.strTotalizadorOriginal).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.strVehiculo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblBitacoraAlerta>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFechaHora).HasColumnType("datetime");
            entity.Property(e => e.datFechaLectura).HasColumnType("datetime");
            entity.Property(e => e.dblVolumen).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.strProducto)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblBitacoraConsola>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__tblBitac__3213E83FB5A2BF70");

            entity.ToTable("tblBitacoraConsola");

            entity.Property(e => e.datFecha)
                .HasDefaultValueSql("(getdate())", "DF_tblBitacoraConsola_datFecha")
                .HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<tblBitacoraImpresion>(entity =>
        {
            entity.HasKey(e => e.intBitacoraImpresion);

            entity.ToTable("tblBitacoraImpresion");

            entity.Property(e => e.datFechaHora).HasColumnType("datetime");
            entity.Property(e => e.strTipoImpresion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblBitacoraMensaje>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFechaCreado).HasColumnType("datetime");
            entity.Property(e => e.datFechaVisto).HasColumnType("datetime");
        });

        modelBuilder.Entity<tblBitacoraTL>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblBitacoraTLS", tb => tb.HasTrigger("INS_BitacoraComTanques"));

            entity.Property(e => e.datFechaHora)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strComando)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.strResultadoHex)
                .HasMaxLength(8000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblBitacoraTXCenter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblBitacoraTXCenter");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.IdSesion).HasMaxLength(50);
            entity.Property(e => e.TPV).HasMaxLength(20);
            entity.Property(e => e.Usuario).HasMaxLength(20);
        });

        modelBuilder.Entity<tblBitacoraVale>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFecha).HasColumnType("datetime");
            entity.Property(e => e.dblMonto).HasColumnType("money");
            entity.Property(e => e.dblMontoCapturado).HasColumnType("money");
            entity.Property(e => e.dblMontoConsumido).HasColumnType("money");
            entity.Property(e => e.dblMontoMaximo).HasColumnType("money");
            entity.Property(e => e.dblMontoMinimo).HasColumnType("money");
            entity.Property(e => e.dblMontoTransaccion).HasColumnType("money");
            entity.Property(e => e.strAccion)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.strDispositivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strEstatus)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.strNoVale)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strRespuesta)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblBitacoraVario>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFechahora).HasColumnType("datetime");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strBandaMagnetica)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strLetraFolio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPie1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPie2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPie3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPie4)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strTarjeta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strTipoTransaccion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strVehiculo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblBitacora_Duplicada>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFechaHora).HasColumnType("datetime");
            entity.Property(e => e.intId).ValueGeneratedOnAdd();
            entity.Property(e => e.strBandaMagnetica)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strCliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strOdometro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPie1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strTarjeta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strTipoTransaccion)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.strVehiculo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblBitacora_Historium>(entity =>
        {
            entity.HasKey(e => e.intSecuencia)
                .HasName("PK__tblBitacora_Hist__02601B2E")
                .HasFillFactor(90);

            entity.Property(e => e.intSecuencia).ValueGeneratedNever();
            entity.Property(e => e.datFechaHora).HasColumnType("datetime");
            entity.Property(e => e.intId).ValueGeneratedOnAdd();
            entity.Property(e => e.strBandaMagnetica)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strCliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strOdometro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPie1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strTarjeta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strTipoTransaccion)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.strVehiculo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblBoletosCinepoli>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.strHTML).IsUnicode(false);
        });

        modelBuilder.Entity<tblBoletosGOBenefit>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Empresa)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.Folio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Monto).HasColumnType("decimal(10, 3)");
            entity.Property(e => e.NoUsuario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreEstacion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TipoBoleto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblCICAlarmasCategoria>(entity =>
        {
            entity.HasKey(e => e.strAlarma).HasFillFactor(90);

            entity.Property(e => e.strAlarma)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblCICAlarmasTipo>(entity =>
        {
            entity.HasKey(e => new { e.strAlarmaCat, e.strAlarmaTipo }).HasFillFactor(90);

            entity.Property(e => e.strAlarmaCat)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.strAlarmaTipo)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblCalibracione>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFechaAlta).HasColumnType("datetime");
            entity.Property(e => e.datFechaCalibracion).HasColumnType("datetime");
            entity.Property(e => e.strRealizadaPor).HasMaxLength(255);
            entity.Property(e => e.strUsuarioAlta).HasMaxLength(255);
        });

        modelBuilder.Entity<tblCantidadTipoDespacho>(entity =>
        {
            entity.HasKey(e => e.intIDCantidadTipoDespacho);

            entity.ToTable("tblCantidadTipoDespacho");

            entity.Property(e => e.intIDCantidadTipoDespacho).ValueGeneratedNever();
        });

        modelBuilder.Entity<tblCargaInicialInventario>(entity =>
        {
            entity.HasKey(e => new { e.intAlmacen, e.intProducto }).HasFillFactor(90);

            entity.ToTable("tblCargaInicialInventario");
        });

        modelBuilder.Entity<tblCatEstado>(entity =>
        {
            entity.HasKey(e => e.intEstado);

            entity.Property(e => e.strNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblCertificadosJSON>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblCertificadosJSON");

            entity.Property(e => e.datFechaEmisionCertificado).HasColumnType("datetime");
            entity.Property(e => e.strNumeroFolioCertificado)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.strRFCCertificado)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.strResultadoCertificado)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblCheckSum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblCheckSum");

            entity.HasIndex(e => new { e.strTabla, e.strNombreLlave, e.strLlave }, "UQ__tblCheck__FD8B11FBA4A1D83C").IsUnique();

            entity.Property(e => e.strLlave)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.strNombreLlave)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strTabla)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblCinepoli>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFecha).HasColumnType("datetime");
            entity.Property(e => e.datFechaConfirmacionImpresion).HasColumnType("datetime");
            entity.Property(e => e.strCodigoSolicitud).HasMaxLength(50);
            entity.Property(e => e.strFolios).HasMaxLength(1000);
            entity.Property(e => e.strIdSesion).HasMaxLength(50);
            entity.Property(e => e.strMensaje).HasMaxLength(250);
            entity.Property(e => e.strMensajeError).HasMaxLength(250);
        });

        modelBuilder.Entity<tblCinepolisBoleto>(entity =>
        {
            entity.HasKey(e => new { e.strCodigoSolicitud, e.strFolio });

            entity.ToTable("tblCinepolisBoleto");

            entity.Property(e => e.strCodigoSolicitud).HasMaxLength(50);
            entity.Property(e => e.strFolio).HasMaxLength(50);
            entity.Property(e => e.datFecha).HasColumnType("datetime");
            entity.Property(e => e.strAgente).HasMaxLength(100);
            entity.Property(e => e.strMensaje).HasMaxLength(250);
            entity.Property(e => e.strPrecio).HasMaxLength(50);
            entity.Property(e => e.strSucursal).HasMaxLength(100);
            entity.Property(e => e.strTitulo).HasMaxLength(100);
        });

        modelBuilder.Entity<tblClientesComercializadorasAfiliada>(entity =>
        {
            entity.HasKey(e => e.intClienteUG).HasName("PK_tblClientesComnercializadorasAfiliadas");

            entity.Property(e => e.intClienteUG).ValueGeneratedNever();
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strNombreCliente)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblClientesConsignacion>(entity =>
        {
            entity.HasKey(e => e.intCliente)
                .HasName("PK__tblClientesConsi__2D47B39A")
                .HasFillFactor(90);

            entity.ToTable("tblClientesConsignacion");

            entity.Property(e => e.intCliente).ValueGeneratedNever();
            entity.Property(e => e.strNombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblColecta>(entity =>
        {
            entity.HasKey(e => e.intFolioColecta);

            entity.Property(e => e.intFolioColecta).ValueGeneratedNever();
            entity.Property(e => e.datFecha).HasColumnType("datetime");
            entity.Property(e => e.dblEfectivo).HasColumnType("money");
            entity.Property(e => e.dblTotal).HasColumnType("money");
            entity.Property(e => e.dblVales).HasColumnType("money");
        });

        modelBuilder.Entity<tblColectasDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblColectasDetalle");

            entity.Property(e => e.decImporte).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<tblColectasInicio>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblColectasInicio");

            entity.Property(e => e.datFechaHora).HasColumnType("datetime");
        });

        modelBuilder.Entity<tblComandosConfiguracion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblComandosConfiguracion");

            entity.Property(e => e.intComando).ValueGeneratedOnAdd();
            entity.Property(e => e.strComando)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblComandosTL>(entity =>
        {
            entity.HasKey(e => e.strComando);

            entity.ToTable("tblComandosTLS");

            entity.Property(e => e.strComando)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.intComando).ValueGeneratedOnAdd();
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblComercializadora>(entity =>
        {
            entity.HasKey(e => e.intComercializadora);

            entity.Property(e => e.intComercializadora).ValueGeneratedNever();
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblComponente>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<tblConexionesAutorizada>(entity =>
        {
            entity.HasKey(e => e.strIP);

            entity.Property(e => e.strIP).HasMaxLength(50);
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strNombre).HasMaxLength(255);
        });

        modelBuilder.Entity<tblConfiguracionBanorte>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblConfiguracionBanorte");

            entity.Property(e => e.strCMD_TRANS)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strMERCHANT_ID)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strMODE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPASSWORD)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strTRANS_TIMEOUT)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strURL)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strUSER)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblConfiguracionPuertoTL>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblConfiguracionPuertoTLS");

            entity.Property(e => e.strCaraterParidad)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.strParidad)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblConfiguracionWebService>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblConfiguracionWebService");

            entity.Property(e => e.strDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strURL_LAN)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.strURL_WAN)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblConsultasUG>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblConsultasUG");

            entity.Property(e => e.datFechaAlta).HasColumnType("datetime");
        });

        modelBuilder.Entity<tblControlesVolumetrico>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFechaUltimoProceso).HasColumnType("datetime");
            entity.Property(e => e.strFecha)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.strMsgEnviado)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.strMsgError)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.strMsgGenerado)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.strMsgProcesado)
                .HasMaxLength(8000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblCorteSeguridad>(entity =>
        {
            entity.HasKey(e => e.intFolioSeguridad);

            entity.ToTable("tblCorteSeguridad");

            entity.Property(e => e.intFolioSeguridad).ValueGeneratedNever();
            entity.Property(e => e.datFecha).HasColumnType("datetime");
            entity.Property(e => e.dblImporte).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<tblCorteSeguridadDesgloce>(entity =>
        {
            entity.HasKey(e => new { e.intFolioSeguridad, e.intFormaPago, e.intDenominacion });

            entity.ToTable("tblCorteSeguridadDesgloce");

            entity.Property(e => e.intDenominacion).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.intCantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<tblCorteSeguridadDet>(entity =>
        {
            entity.HasKey(e => new { e.intFolioSeguridad, e.intFormaPago });

            entity.ToTable("tblCorteSeguridadDet");

            entity.Property(e => e.dblImporte).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<tblCortesManuale>(entity =>
        {
            entity.HasKey(e => new { e.intFolioCorte, e.intTurno, e.intIsla, e.intUsuario, e.intProducto }).HasFillFactor(90);
        });

        modelBuilder.Entity<tblCortesReporte>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.intFolioCorte, e.intIsla, e.intProducto, e.dblPrecioUnitario, e.datFechaCorte }, "IX_tblCortesReportes_intFolioCorte_intIsla_intProducto_dblPrecioUnitario_datFechaCorte");

            entity.Property(e => e.datFechaCorte).HasColumnType("datetime");
            entity.Property(e => e.dblCorteL).HasDefaultValue(0.0);
            entity.Property(e => e.dblCorteP).HasDefaultValue(0.0);
        });

        modelBuilder.Entity<tblDenominacionesTipoVentum>(entity =>
        {
            entity.HasKey(e => new { e.intTipoVenta, e.intDenominacion });

            entity.Property(e => e.intDenominacion).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.strDescripcion).HasMaxLength(50);
        });

        modelBuilder.Entity<tblDictamenDocumento>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFechaAlta).HasColumnType("datetime");
            entity.Property(e => e.datFechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.intIdDictamenDocumento).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<tblDictamenesDET>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblDictamenesDET");

            entity.Property(e => e.decIndiceOctano).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.decPorcentajeNoFosil).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.intId).ValueGeneratedOnAdd();
            entity.Property(e => e.strFolio).HasMaxLength(255);
        });

        modelBuilder.Entity<tblDictamenesENC>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblDictamenesENC");

            entity.Property(e => e.datFechaAlta).HasColumnType("datetime");
            entity.Property(e => e.datFechaEmision).HasColumnType("datetime");
            entity.Property(e => e.intId).ValueGeneratedOnAdd();
            entity.Property(e => e.strFolio).HasMaxLength(255);
            entity.Property(e => e.strNombre).HasMaxLength(255);
            entity.Property(e => e.strRFC).HasMaxLength(15);
            entity.Property(e => e.strUsuarioAlta).HasMaxLength(255);
        });

        modelBuilder.Entity<tblDispensario>(entity =>
        {
            entity.HasKey(e => e.intDispensario).HasFillFactor(90);

            entity.ToTable(tb => tb.HasTrigger("UPD_Dispensarios"));

            entity.Property(e => e.intDispensario).ValueGeneratedNever();
            entity.Property(e => e.datFechaLectura).HasColumnType("datetime");
            entity.Property(e => e.strRFID).HasMaxLength(255);
            entity.Property(e => e.strTipoSurtidor)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.HasOne(d => d.intIslaNavigation).WithMany(p => p.tblDispensarios)
                .HasForeignKey(d => d.intIsla)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDispensarios_tblIslas");
        });

        modelBuilder.Entity<tblDispensarioXAlmacen>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblDispensarioXAlmacen");

            entity.Property(e => e.strDescripcion).IsUnicode(false);
        });

        modelBuilder.Entity<tblDocumento>(entity =>
        {
            entity.HasKey(e => new { e.intLiquidacion, e.intIsla, e.intDocumento }).HasFillFactor(90);

            entity.Property(e => e.strFolioDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strNoCuenta)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblDocumentosAnexo>(entity =>
        {
            entity.HasKey(e => e.intIdDocumentoAnexo).HasName("PK__tblDocum__86549E66D06BE5FF");

            entity.ToTable("tblDocumentosAnexo");

            entity.Property(e => e.datFechaAlta).HasColumnType("datetime");
            entity.Property(e => e.datFechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.strNombreArchivo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strObservacion)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblDocumentosCV>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblDocumentosCV");

            entity.Property(e => e.datFechaAlta).HasColumnType("datetime");
            entity.Property(e => e.datFechaDocto).HasColumnType("datetime");
            entity.Property(e => e.dblDensidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.dblPrecio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.intEtanol).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.intFolioLote).HasDefaultValue(0L, "DF__tblDocume__intFo__6C28BFBD");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.intImporte).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.strAclaracion).IsUnicode(false);
            entity.Property(e => e.strClaveVehiculo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPermisoAD).HasMaxLength(50);
            entity.Property(e => e.strPermisoAlma).HasMaxLength(100);
            entity.Property(e => e.strPermisoTrans).HasMaxLength(50);
            entity.Property(e => e.strTerminalAD).HasMaxLength(3);
            entity.Property(e => e.strTipoDocto)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.strUsuarioAlta)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblDonativo>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.intDonativo).ValueGeneratedOnAdd();
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strRutaReporte)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblErroresServicio>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblErroresServicio");

            entity.Property(e => e.datFechaHora).HasColumnType("datetime");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strCompania)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strMensaje)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.strTelefono)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strTipoError)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblEstatusApp>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFecha).HasColumnType("datetime");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strEstatusConsola).HasMaxLength(50);
            entity.Property(e => e.strEstatusMonitor).HasMaxLength(50);
            entity.Property(e => e.strEstatusTransacciones).HasMaxLength(50);
        });

        modelBuilder.Entity<tblEstatusSesion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblEstatusSesion");

            entity.Property(e => e.strDescripcion).HasMaxLength(150);
        });

        modelBuilder.Entity<tblExistencia>(entity =>
        {
            entity.HasKey(e => new { e.intAlmacen, e.intProducto }).HasFillFactor(90);

            entity.HasOne(d => d.intAlmacenNavigation).WithMany(p => p.tblExistencia)
                .HasForeignKey(d => d.intAlmacen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblExistencias_tblAlmacenes");

            entity.HasOne(d => d.intProductoNavigation).WithMany(p => p.tblExistencia)
                .HasForeignKey(d => d.intProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblExistencias_tblProductos");
        });

        modelBuilder.Entity<tblExistenciasCV>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblExistenciasCV");

            entity.Property(e => e.datFechaHora).HasColumnType("datetime");
            entity.Property(e => e.datFechaHoraAnterior).HasColumnType("datetime");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strEstatus)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblFechasTransmicion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblFechasTransmicion");

            entity.Property(e => e.datUltimaFechaTF).HasColumnType("datetime");
            entity.Property(e => e.datUltimaFechaTU).HasColumnType("datetime");
        });

        modelBuilder.Entity<tblFolioLiquidacionXDi>(entity =>
        {
            entity.HasKey(e => e.intFolioLiquidacionDis).HasName("PK__tblFolio__F0BDEF616C0FFC81");

            entity.Property(e => e.datFechaAlta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.datFechaLiquidacion).HasColumnType("datetime");
            entity.Property(e => e.strUsuarioLiquidacion).IsUnicode(false);
        });

        modelBuilder.Entity<tblFoliosCorte>(entity =>
        {
            entity.HasKey(e => e.intFolioCorte)
                .HasName("PK_tblCortes")
                .HasFillFactor(90);

            entity.ToTable("tblFoliosCorte");

            entity.Property(e => e.intFolioCorte).ValueGeneratedNever();
            entity.Property(e => e.datFechaContable).HasColumnType("datetime");
            entity.Property(e => e.datFechaFinal).HasColumnType("datetime");
            entity.Property(e => e.datFechaInicial).HasColumnType("datetime");
            entity.Property(e => e.datFechaLiquidacion).HasColumnType("datetime");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<tblFoliosCorteDi>(entity =>
        {
            entity.HasKey(e => e.intFolioCorteDis).HasName("PK__tblFolio__2E3DB613608E27A0");

            entity.Property(e => e.datFechaAlta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.datFechaFin).HasColumnType("datetime");
            entity.Property(e => e.datFechaIni).HasColumnType("datetime");
            entity.Property(e => e.datFechaLiquidacion).HasColumnType("datetime");
            entity.Property(e => e.strUsuarioAlta).IsUnicode(false);
        });

        modelBuilder.Entity<tblFoliosReleacionRecepcionesDocumento>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.intID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<tblFormasPago>(entity =>
        {
            entity.HasKey(e => e.intFormaPago).HasFillFactor(90);

            entity.ToTable("tblFormasPago");

            entity.Property(e => e.intFormaPago).ValueGeneratedNever();
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblGoBenefit>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<tblGoBenefitsAcumulacion>(entity =>
        {
            entity.HasKey(e => e.intTransaccion).HasName("PK_tblGoBenefitsAcumulacion_1");

            entity.ToTable("tblGoBenefitsAcumulacion");

            entity.Property(e => e.intTransaccion).ValueGeneratedNever();
            entity.Property(e => e.datFecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<tblGrupo>(entity =>
        {
            entity.HasKey(e => e.intGrupo)
                .HasName("PK_tblPuestos")
                .HasFillFactor(90);

            entity.Property(e => e.intGrupo).ValueGeneratedNever();
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblHorasCV>(entity =>
        {
            entity.HasKey(e => e.intHora).HasFillFactor(90);

            entity.ToTable("tblHorasCV");

            entity.Property(e => e.intHora).ValueGeneratedNever();
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblImpresione>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.intTransaccion, e.intTipo }, "IX_tblImpresiones");

            entity.Property(e => e.datFechaHora).HasColumnType("datetime");
        });

        modelBuilder.Entity<tblInterface>(entity =>
        {
            entity.HasKey(e => e.intID).HasName("PK__tblInter__11B6793298624D35");

            entity.Property(e => e.strDescripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strNombre)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblInventarioTanques_CV>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblInventarioTanques_CV");

            entity.HasIndex(e => new { e.intTanque, e.intProducto, e.datFechaLectura }, "idx_InventariosTanques");

            entity.Property(e => e.datFechaLectura).HasColumnType("datetime");
            entity.Property(e => e.dblNivelAgua).HasDefaultValue(0.0, "DF__tblInvent__dblNi__1AD42F6E");
            entity.Property(e => e.dblNivelCombustible).HasDefaultValue(0.0, "DF__tblInvent__dblNi__19E00B35");
            entity.Property(e => e.dblTemperatura).HasDefaultValue(0.0, "DF__tblInvent__dblTe__1BC853A7");
            entity.Property(e => e.dblVolumen).HasDefaultValue(0.0, "DF__tblInvent__dblVo__17F7C2C3");
            entity.Property(e => e.dblVolumenAgua).HasDefaultValue(0.0, "DF__tblInvent__dblVo__1CBC77E0");
            entity.Property(e => e.dblVolumenTC).HasDefaultValue(0.0, "DF__tblInvent__dblVo__17039E8A");
            entity.Property(e => e.dblVolumenXLlenar).HasDefaultValue(0.0, "DF__tblInvent__dblVo__18EBE6FC");
        });

        modelBuilder.Entity<tblIsla>(entity =>
        {
            entity.HasKey(e => e.intIsla).HasFillFactor(90);

            entity.Property(e => e.intIsla).ValueGeneratedNever();
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strImpresora).HasMaxLength(50);
        });

        modelBuilder.Entity<tblIslaAlmacen>(entity =>
        {
            entity.HasKey(e => new { e.intIsla, e.intAlmacen }).HasFillFactor(90);

            entity.ToTable("tblIslaAlmacen");
        });

        modelBuilder.Entity<tblLectorBitacora>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblLectorBitacora");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<tblLiqXDisFormasPago>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblLiqXDisFormasPago");

            entity.Property(e => e.dblMonto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.strDescripcion).IsUnicode(false);
        });

        modelBuilder.Entity<tblLiqXDisProducto>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.dblImporte).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.intExistenciaFinal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.intExistenciaInicial).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.intSalida).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.strProducto).IsUnicode(false);
            entity.Property(e => e.strTipoProducto).IsUnicode(false);
        });

        modelBuilder.Entity<tblLiquidacionDetPago>(entity =>
        {
            entity.HasKey(e => new { e.intFolioLiquidacion, e.intFormaPago }).HasFillFactor(90);

            entity.HasOne(d => d.intFormaPagoNavigation).WithMany(p => p.tblLiquidacionDetPagos)
                .HasForeignKey(d => d.intFormaPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblLiquidacionDetPagos_tblFormasPago");
        });

        modelBuilder.Entity<tblLiquidacionDetPagosAjuste>(entity =>
        {
            entity.HasKey(e => new { e.intFolioLiquidacion, e.intFormaPago, e.intSecuencia })
                .HasName("PK_tblLiquidacionDetPagosAjuste_1")
                .HasFillFactor(90);

            entity.ToTable("tblLiquidacionDetPagosAjuste");

            entity.Property(e => e.intSecuencia).ValueGeneratedOnAdd();
            entity.Property(e => e.datFechaCaptura)
                .HasDefaultValueSql("(getdate())", "DF_tblLiquidacionDetPagosAjuste_datFechaCaptura")
                .HasColumnType("datetime");
            entity.Property(e => e.strPCCaptura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strUsuarioCaptura)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblLiquidacionDetProd>(entity =>
        {
            entity.HasKey(e => new { e.intFolioLiquidacion, e.intProducto, e.dblPrecioUnitario });

            entity.ToTable("tblLiquidacionDetProd");
        });

        modelBuilder.Entity<tblLiquidacionDetProdAjuste>(entity =>
        {
            entity.HasKey(e => new { e.intFolioLiquidacion, e.intProducto, e.intSecuencia }).HasFillFactor(90);

            entity.ToTable("tblLiquidacionDetProdAjuste");

            entity.Property(e => e.intSecuencia).ValueGeneratedOnAdd();
            entity.Property(e => e.datFechaCaptura)
                .HasDefaultValueSql("(getdate())", "DF_tblLiquidacionDetProdAjuste_datFechaCaptura")
                .HasColumnType("datetime");
            entity.Property(e => e.strPCCaptura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strUsuarioCaptura)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblLiquidacionEnc>(entity =>
        {
            entity.HasKey(e => new { e.intFolioCorte, e.intFolioLiquidacion }).HasFillFactor(90);

            entity.ToTable("tblLiquidacionEnc");

            entity.Property(e => e.datFechaCaptura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.datFechaLiquidacion).HasColumnType("datetime");
            entity.Property(e => e.strDespachadores)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.strNombreUsuario)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.strPCCaptura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strUsuarioCaptura)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.intFolioCorteNavigation).WithMany(p => p.tblLiquidacionEncs)
                .HasForeignKey(d => d.intFolioCorte)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblLiquidacionEnc_tblFoliosCorte");
        });

        modelBuilder.Entity<tblLiquidacionXDi>(entity =>
        {
            entity.HasKey(e => e.intId).HasName("PK__tblLiqui__11B678D2874655DF");

            entity.Property(e => e.datFechaAlta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.datFechaLiquidacion).HasColumnType("datetime");
            entity.Property(e => e.strDespachador).IsUnicode(false);
            entity.Property(e => e.strUsuarioLiquidacion).IsUnicode(false);
        });

        modelBuilder.Entity<tblListaPropiedade>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.strIDSesion, "IX_tblListaPropiedades_strIDSesion");

            entity.HasIndex(e => new { e.strIDSesion, e.strPropiedad }, "IX_tblListaPropiedades_strIDSesion_strPropiedad");

            entity.Property(e => e.byteValor)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.decValor).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.strIDSesion).HasMaxLength(255);
            entity.Property(e => e.strPropiedad).HasMaxLength(50);
        });

        modelBuilder.Entity<tblLogConsultaUG>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblLogConsultaUG");

            entity.Property(e => e.datFecha).HasColumnType("datetime");
            entity.Property(e => e.strMensajeRespuesta).IsUnicode(false);
            entity.Property(e => e.strTipodeConsulta).IsUnicode(false);
        });

        modelBuilder.Entity<tblManguera>(entity =>
        {
            entity.HasKey(e => new { e.intDispensario, e.intManguera }).HasFillFactor(90);

            entity.Property(e => e.dblLimiteImporte).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.dblLimiteLitros).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strTipoSurtidor)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.HasOne(d => d.intDispensarioNavigation).WithMany(p => p.tblMangueras)
                .HasForeignKey(d => d.intDispensario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMangueras_tblDispensarios");

            entity.HasOne(d => d.intProductoNavigation).WithMany(p => p.tblMangueras)
                .HasForeignKey(d => d.intProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMangueras_tblProductos");
        });

        modelBuilder.Entity<tblMedidore>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFechaCalibracion).HasColumnType("datetime");
            entity.Property(e => e.datFechaVigenciaCertificado).HasColumnType("datetime");
            entity.Property(e => e.dblIncertidumbre).HasColumnType("decimal(6, 3)");
            entity.Property(e => e.strDescripcion).HasMaxLength(255);
            entity.Property(e => e.strIdSistemaMedicion).HasMaxLength(255);
            entity.Property(e => e.strUbicacion).HasMaxLength(255);
        });

        modelBuilder.Entity<tblMedidoresJSON>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblMedidoresJSON");

            entity.Property(e => e.datVigenciaSistemaMedicion).HasColumnType("datetime");
            entity.Property(e => e.dblIncertidumbreSistemaMedicion).HasColumnType("decimal(4, 3)");
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.strSistemaMedicion)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblMensajesApp>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.intID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<tblMenuPrincipal>(entity =>
        {
            entity.HasKey(e => e.intMenu);

            entity.ToTable("tblMenuPrincipal");

            entity.Property(e => e.intMenu).ValueGeneratedNever();
            entity.Property(e => e.strDescripcion).HasMaxLength(50);
            entity.Property(e => e.strIDImagen).HasMaxLength(50);
        });

        modelBuilder.Entity<tblMenusTPV>(entity =>
        {
            entity.HasKey(e => new { e.intMenu, e.strMenuPadre });

            entity.ToTable("tblMenusTPV");

            entity.Property(e => e.strMenuPadre).HasMaxLength(50);
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strArchivo).HasMaxLength(255);
            entity.Property(e => e.strMenu).HasMaxLength(100);
            entity.Property(e => e.strMenuSiguiente).HasMaxLength(50);
            entity.Property(e => e.strParametros).HasMaxLength(100);
        });

        modelBuilder.Entity<tblMeta>(entity =>
        {
            entity.HasKey(e => e.intId).HasName("PK_tblMeta");
        });

        modelBuilder.Entity<tblModulo>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.strNombre)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblModulosUA>(entity =>
        {
            entity.ToTable("tblModulosUA");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.dllName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.pathString)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblMoneda>(entity =>
        {
            entity.HasKey(e => e.intMoneda).HasFillFactor(90);

            entity.Property(e => e.intMoneda).ValueGeneratedNever();
            entity.Property(e => e.strAbreviatura)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.strNombreCorto)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblMovimientosInv>(entity =>
        {
            entity.HasKey(e => e.intMovimiento)
                .HasName("PK_tblMovimientos")
                .HasFillFactor(90);

            entity.ToTable("tblMovimientosInv");

            entity.Property(e => e.intMovimiento).ValueGeneratedNever();
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.HasOne(d => d.intTipoMovimientoNavigation).WithMany(p => p.tblMovimientosInvs)
                .HasForeignKey(d => d.intTipoMovimiento)
                .HasConstraintName("FK_tblMovimientosInv_tblTiposMovimientoInv");
        });

        modelBuilder.Entity<tblMovimientosInvDet>(entity =>
        {
            entity.HasKey(e => e.intSecuencia).HasFillFactor(90);

            entity.ToTable("tblMovimientosInvDet");

            entity.Property(e => e.intSecuencia).ValueGeneratedNever();
            entity.Property(e => e.datFecha).HasColumnType("datetime");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.strPC)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strReferencia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strUsuario)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.intAlmacenNavigation).WithMany(p => p.tblMovimientosInvDets)
                .HasForeignKey(d => d.intAlmacen)
                .HasConstraintName("FK_tblMovimientosInvDet_tblAlmacenes");

            entity.HasOne(d => d.intMovimientoNavigation).WithMany(p => p.tblMovimientosInvDets)
                .HasForeignKey(d => d.intMovimiento)
                .HasConstraintName("FK_tblMovimientosInvDet_tblMovimientosInv");

            entity.HasOne(d => d.intProductoNavigation).WithMany(p => p.tblMovimientosInvDets)
                .HasForeignKey(d => d.intProducto)
                .HasConstraintName("FK_tblMovimientosInvDet_tblProductos");
        });

        modelBuilder.Entity<tblNexGen>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblNexGen");

            entity.Property(e => e.CommPort)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DataBits)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeviceClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeviceID)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EthernetPort)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HostID)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumRetries)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Parity)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RFADevice)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ServiceClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Speed)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StopsBits)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TimeOut)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TraceFormat)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TraceRFA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TraceTruncate)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblNotificationsIP>(entity =>
        {
            entity.HasKey(e => e.intId);

            entity.ToTable("tblNotificationsIP");

            entity.Property(e => e.strHostName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strIp)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblPagoGOBenefit>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ID).ValueGeneratedOnAdd();
            entity.Property(e => e.datFechaPago).HasColumnType("datetime");
            entity.Property(e => e.decMonto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.strBandaM)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strCodigoInterno)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strCodigoTrx)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strMensaje)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblParametro>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFechaContable).HasColumnType("datetime");
            entity.Property(e => e.datFechaHora).HasColumnType("datetime");
            entity.Property(e => e.dblCompensacionLitros).HasColumnType("decimal(5, 3)");
            entity.Property(e => e.dblLatitud).HasColumnType("decimal(10, 7)");
            entity.Property(e => e.dblLimiteCorteSeguridad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.dblLimiteImporte).HasDefaultValue(0.0);
            entity.Property(e => e.dblLimiteLitros).HasDefaultValue(0.0);
            entity.Property(e => e.dblLongitud).HasColumnType("decimal(10, 7)");
            entity.Property(e => e.dblcompensacionImporte).HasColumnType("decimal(5, 3)");
            entity.Property(e => e.strActividad)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.strCaracterSitio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strCiudadEstado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strCiudadEstadoSucursal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strClaveIdentificacion).HasMaxLength(100);
            entity.Property(e => e.strClavePemex)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.strClienteID_BTE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strClientePemex).IsUnicode(false);
            entity.Property(e => e.strCodigoPostal)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.strColonia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strColoniaSucursal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strConsola).HasMaxLength(50);
            entity.Property(e => e.strDireccion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strDireccionSucursal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strDirectorioActualizaciones)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.strIPCTG)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strLicenciaSantanderDev).HasMaxLength(100);
            entity.Property(e => e.strLicenciaSantanderProd).HasMaxLength(100);
            entity.Property(e => e.strMarcaDispensario)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.strMarcaGasolinera).HasMaxLength(50);
            entity.Property(e => e.strModalidadCaracter).HasMaxLength(50);
            entity.Property(e => e.strMode_BTE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strName_BTE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strNoCorresponsal)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.strNomEmpresa)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strNomSucursal)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strNombreRepresentante).HasMaxLength(255);
            entity.Property(e => e.strPCCTG)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPassCinepolis).HasMaxLength(100);
            entity.Property(e => e.strPasswordGoBenefits).HasMaxLength(50);
            entity.Property(e => e.strPassword_BTE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strRFC)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.strRFCProveedor)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.strRFCRepresentante)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.strRetoMobilApiKey).HasMaxLength(150);
            entity.Property(e => e.strRetoMobilKid).HasMaxLength(150);
            entity.Property(e => e.strRetoMobilPublicKey).HasMaxLength(150);
            entity.Property(e => e.strRetoMobilUrl).HasMaxLength(150);
            entity.Property(e => e.strTelefono)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.strTipoCaracter).HasMaxLength(50);
            entity.Property(e => e.strURLTablero).IsUnicode(false);
            entity.Property(e => e.strUnidadMedida).HasMaxLength(100);
            entity.Property(e => e.strUserCinepolis).HasMaxLength(100);
            entity.Property(e => e.strUserGoBenefits).HasMaxLength(50);
            entity.Property(e => e.strVersion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strVersionCV).HasMaxLength(50);
            entity.Property(e => e.strVersionConsola)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strWEBSITE).HasMaxLength(255);
        });

        modelBuilder.Entity<tblParametrosServiciosWEB>(entity =>
        {
            entity.HasKey(e => new { e.intServicio, e.intParametro }).HasFillFactor(90);

            entity.ToTable("tblParametrosServiciosWEB");

            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strNombreParametro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strValorParametro)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblParametrosTPV>(entity =>
        {
            entity.HasKey(e => e.intIDParametro).HasName("PK_tblParametro");

            entity.ToTable("tblParametrosTPV");

            entity.Property(e => e.intIDParametro).ValueGeneratedNever();
            entity.Property(e => e.strNombre).HasMaxLength(255);
            entity.Property(e => e.strTipo).HasMaxLength(50);
            entity.Property(e => e.strValorDefault).HasMaxLength(255);
        });

        modelBuilder.Entity<tblPaso>(entity =>
        {
            entity.HasKey(e => e.intIDPaso).HasName("PK_tblControl");

            entity.ToTable("tblPaso");

            entity.Property(e => e.intIDPaso).ValueGeneratedNever();
            entity.Property(e => e.strClassControl).HasMaxLength(255);
            entity.Property(e => e.strDLLControl).HasMaxLength(255);
            entity.Property(e => e.strNombre).HasMaxLength(50);
        });

        modelBuilder.Entity<tblPasosManager>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblPasosManager");

            entity.Property(e => e.strNombre).HasMaxLength(50);
            entity.Property(e => e.strQueryValores).IsUnicode(false);
        });

        modelBuilder.Entity<tblPasosManager_jul14_2025>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblPasosManager_jul14_2025");

            entity.Property(e => e.strNombre).HasMaxLength(50);
            entity.Property(e => e.strQueryValores).IsUnicode(false);
        });

        modelBuilder.Entity<tblPasosManager_mar01_2025>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblPasosManager_mar01_2025");

            entity.Property(e => e.strNombre).HasMaxLength(50);
            entity.Property(e => e.strQueryValores).IsUnicode(false);
        });

        modelBuilder.Entity<tblPemexConfiguracion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblPemexConfiguracion");

            entity.Property(e => e.strHora)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.strHoraFinal)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.strHoraGeneracion)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.strMinutos)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.strMinutosParaGenerar)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.strMinutosParaconsultar)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.strPassKey)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.strPasswordCV)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPath_Conexion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.strPath_XML)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.strRutaCer)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.strRutaKey)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.strUsuarioCV)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblPermiso>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.strDescripcion).HasMaxLength(255);
            entity.Property(e => e.strNombre).HasMaxLength(255);
        });

        modelBuilder.Entity<tblPermisosObjeto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblPermisosObjeto");
        });

        modelBuilder.Entity<tblPolizaLiquidacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblPolizaLiquidacion");

            entity.Property(e => e.datFecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<tblPreciosProgramado>(entity =>
        {
            entity.HasKey(e => new { e.datFechaProgramada, e.intProducto });

            entity.Property(e => e.datFechaProgramada).HasColumnType("datetime");
            entity.Property(e => e.bitAfectado).HasDefaultValue(false, "DF_tblPreciosProgramados_bitAfectado");
            entity.Property(e => e.datFechaAlta).HasColumnType("datetime");
            entity.Property(e => e.strMaquinaAlta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strUsuarioAlta)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblPreciosProgramadosAplicado>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFechaEnvíoANexGen).HasColumnType("datetime");
            entity.Property(e => e.datFechaProgramada).HasColumnType("datetime");
            entity.Property(e => e.datFechaVericiacionAplicacion).HasColumnType("datetime");
            entity.Property(e => e.intId).ValueGeneratedOnAdd();
            entity.Property(e => e.strEstacion)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblPresentacione>(entity =>
        {
            entity.HasKey(e => e.intPresentacion).HasFillFactor(90);

            entity.Property(e => e.intPresentacion).ValueGeneratedNever();
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<tblPresupuestoADLUB_Estacion>(entity =>
        {
            entity.HasKey(e => new { e.intAño, e.intMes, e.intProducto });

            entity.ToTable("tblPresupuestoADLUB_Estacion");

            entity.Property(e => e.datFechaActualizacion).HasColumnType("datetime");
        });

        modelBuilder.Entity<tblProceso>(entity =>
        {
            entity.HasKey(e => e.intIDProceso);

            entity.Property(e => e.intIDProceso).ValueGeneratedNever();
            entity.Property(e => e.strDescripcion).HasMaxLength(50);
        });

        modelBuilder.Entity<tblProcesoPaso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblProcesoPaso");
        });

        modelBuilder.Entity<tblProcesoPasoManager>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblProcesoPasoManager");
        });

        modelBuilder.Entity<tblProcesoPasoManager_respaldo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblProcesoPasoManager_respaldo");
        });

        modelBuilder.Entity<tblProducto>(entity =>
        {
            entity.HasKey(e => e.intProducto).HasFillFactor(90);

            entity.Property(e => e.intProducto).ValueGeneratedNever();
            entity.Property(e => e.bitCapturaManual).HasDefaultValue(false);
            entity.Property(e => e.datFechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.datFechaAlta).HasColumnType("datetime");
            entity.Property(e => e.intEtanol).HasColumnType("decimal(4, 2)");
            entity.Property(e => e.intPuertoCOMTablero)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("COM1");
            entity.Property(e => e.intTablero).HasDefaultValue(1);
            entity.Property(e => e.strClaveIdentificacion).HasMaxLength(50);
            entity.Property(e => e.strClaveProducto).HasMaxLength(50);
            entity.Property(e => e.strClaveSubProducto).HasMaxLength(50);
            entity.Property(e => e.strCodigoBarras)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strEtanol).HasMaxLength(2);
            entity.Property(e => e.strFolioPemex)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.strMaquinaAlta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strUsuarioActualizacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strUsuarioAlta)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.intPresentacionNavigation).WithMany(p => p.tblProductos)
                .HasForeignKey(d => d.intPresentacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblProductos_tblPresentaciones");

            entity.HasOne(d => d.intTipoProductoNavigation).WithMany(p => p.tblProductos)
                .HasForeignKey(d => d.intTipoProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblProductos_tblTiposProducto");
        });

        modelBuilder.Entity<tblProductosCV>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblProductosCV");

            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strMarca)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strMarcaDescripcion)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.strProducto)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.strProductoDescripcion)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.strSubProductoDescripcion)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.strSubproducto)
                .HasMaxLength(70)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblProductosHist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblProductosHist");

            entity.Property(e => e.datFechaAlta).HasColumnType("datetime");
        });

        modelBuilder.Entity<tblProductos_BajaInventario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblProductos_BajaInventario");

            entity.Property(e => e.datFechaBaja).HasColumnType("datetime");
            entity.Property(e => e.strUsuarioBaja)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblPromocione>(entity =>
        {
            entity.HasKey(e => e.intPromocion).HasName("PK_Promocion");

            entity.Property(e => e.intPromocion).ValueGeneratedNever();
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strArchivo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strOperacion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.strPromocion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblPromocionesDescuento>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFechaFinal).HasColumnType("datetime");
            entity.Property(e => e.datFechaInicial).HasColumnType("datetime");
            entity.Property(e => e.dblDescuento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.dblMontoMinimo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.dblVolumenMinimo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.strDiasSemana).IsUnicode(false);
            entity.Property(e => e.strFormasPago).IsUnicode(false);
            entity.Property(e => e.strHorasValida).IsUnicode(false);
            entity.Property(e => e.strProductosValidos).IsUnicode(false);
        });

        modelBuilder.Entity<tblPropiedaesTankAgent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblPropiedaesTankAgent");

            entity.Property(e => e.strClave).HasMaxLength(50);
            entity.Property(e => e.strTipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblProveedore>(entity =>
        {
            entity.HasKey(e => e.intProveedor).HasFillFactor(90);

            entity.Property(e => e.intProveedor).ValueGeneratedNever();
            entity.Property(e => e.datFechaCaptura).HasColumnType("datetime");
            entity.Property(e => e.datFechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.strCP)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.strCiudad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strColonia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strDireccion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strEstado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strFax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strNombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strPCCaptura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPCModificacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strRFC)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.strTelefonos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strUsuarioCaptura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strUsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblProveedoresCRE>(entity =>
        {
            entity.HasKey(e => e.strPermisoCRE);

            entity.ToTable("tblProveedoresCRE");

            entity.Property(e => e.strPermisoCRE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblProveedoresCV>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblProveedoresCV");

            entity.Property(e => e.strNombreProveedor).HasMaxLength(50);
            entity.Property(e => e.strPermisoImportacion).HasMaxLength(50);
            entity.Property(e => e.strPermisoProveedor).HasMaxLength(50);
            entity.Property(e => e.strRFCProveedor).HasMaxLength(15);
            entity.Property(e => e.strTipoProveedor).HasMaxLength(50);
        });

        modelBuilder.Entity<tblRecepcionDictamene>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.intidDictamen).ValueGeneratedOnAdd();
            entity.Property(e => e.strFechaEmisionDictamen).HasColumnType("datetime");
            entity.Property(e => e.strLoteDictamen).HasMaxLength(50);
            entity.Property(e => e.strNumeroFolioDictamen).HasMaxLength(50);
            entity.Property(e => e.strRFCDictamen).HasMaxLength(50);
        });

        modelBuilder.Entity<tblRecepcionesCV>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblRecepcionesCV", tb => tb.HasTrigger("Del_Recepciones"));

            entity.Property(e => e.bitCapturado).HasDefaultValue(false, "DF_tblRecepcionesCV_bitCapturado");
            entity.Property(e => e.datFechaAlta).HasColumnType("datetime");
            entity.Property(e => e.datFechaHoraFinal).HasColumnType("datetime");
            entity.Property(e => e.datFechaHoraInicial).HasColumnType("datetime");
            entity.Property(e => e.intEtanolTeorico).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.intFolioLote).HasDefaultValue(0L);
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strTipoRegistro).IsUnicode(false);
        });

        modelBuilder.Entity<tblRecepcionesCVXConfirmar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblRecepcionesCVXConfirmar");

            entity.Property(e => e.datFechaAlta).HasColumnType("datetime");
            entity.Property(e => e.datFechaHoraFinal).HasColumnType("datetime");
            entity.Property(e => e.datFechaHoraInicial).HasColumnType("datetime");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<tblRecepcionesCV_eliminado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblRecepcionesCV_eliminado");

            entity.Property(e => e.datFechaAlta).HasColumnType("datetime");
            entity.Property(e => e.datFechaHoraFinal).HasColumnType("datetime");
            entity.Property(e => e.datFechaHoraInicial).HasColumnType("datetime");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<tblRecepcionesDet>(entity =>
        {
            entity.HasKey(e => new { e.intRecepcion, e.intPartida })
                .HasName("PK_tblRecepcionesDet_1")
                .HasFillFactor(90);

            entity.ToTable("tblRecepcionesDet");

            entity.HasOne(d => d.intProductoNavigation).WithMany(p => p.tblRecepcionesDets)
                .HasForeignKey(d => d.intProducto)
                .HasConstraintName("FK_tblRecepcionesDet_tblProductos");

            entity.HasOne(d => d.intRecepcionNavigation).WithMany(p => p.tblRecepcionesDets)
                .HasForeignKey(d => d.intRecepcion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblRecepcionesDet_tblRecepcionesEnc");
        });

        modelBuilder.Entity<tblRecepcionesEnc>(entity =>
        {
            entity.HasKey(e => e.intRecepcion)
                .HasName("PK_tblRecepcionesLiq")
                .HasFillFactor(90);

            entity.ToTable("tblRecepcionesEnc");

            entity.HasIndex(e => new { e.intProveedor, e.intFolioFactura }, "IX_tblRecepcionesEnc")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.intRecepcion).ValueGeneratedNever();
            entity.Property(e => e.datFechaCaptura).HasColumnType("datetime");
            entity.Property(e => e.datFechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.datFechaRecepcion).HasColumnType("datetime");
            entity.Property(e => e.strPCCaptura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPCModificacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strUsuarioCaptura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strUsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblRegistroEjecucionActualizacion>(entity =>
        {
            entity.HasKey(e => e.intId).HasName("PK__tblRegis__11B678D28BCF0B2C");

            entity.ToTable("tblRegistroEjecucionActualizacion");

            entity.Property(e => e.datFechaEjecucion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.strVersion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblRelacionDispensarioTanque>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblRelacionDispensarioTanque");

            entity.Property(e => e.strDispensario)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.strTanque)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblRelacionTPVIsla>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<tblReporte>(entity =>
        {
            entity.HasKey(e => new { e.intReporte, e.intTipoReporte, e.intOrden })
                .HasName("PK_tblReportes_1")
                .HasFillFactor(90);

            entity.HasIndex(e => e.intReporte, "UK_tblReportes")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.bitActivo).HasDefaultValue(true, "DF_tblReportes_bitActivo");
            entity.Property(e => e.strComandos)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.strNombre)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strNombreFisico)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblRequisitosApp>(entity =>
        {
            entity.HasKey(e => new { e.intRequisito, e.intAPP }).HasFillFactor(90);

            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strMD5).HasMaxLength(255);
            entity.Property(e => e.strNombre).HasMaxLength(50);
            entity.Property(e => e.strRutaArchivo).HasMaxLength(255);
        });

        modelBuilder.Entity<tblRolUsuario>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK_tblTipoUsuario");

            entity.ToTable("tblRolUsuario");

            entity.Property(e => e.descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblRole>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.strDescripcion).HasMaxLength(255);
            entity.Property(e => e.strNombre).HasMaxLength(255);
        });

        modelBuilder.Entity<tblSeguridadModulo>(entity =>
        {
            entity.HasKey(e => e.intModulo).HasFillFactor(90);

            entity.Property(e => e.intModulo).ValueGeneratedNever();
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblSeguridadNivele>(entity =>
        {
            entity.HasKey(e => new { e.intGrupoUsuario, e.intModulo, e.intNivel }).HasFillFactor(90);

            entity.Property(e => e.strDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.intModuloNavigation).WithMany(p => p.tblSeguridadNiveles)
                .HasForeignKey(d => d.intModulo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblSeguridadNiveles_tblSeguridadModulos");
        });

        modelBuilder.Entity<tblSesione>(entity =>
        {
            entity.HasKey(e => e.strIdSession);

            entity.Property(e => e.strIdSession).HasMaxLength(50);
            entity.Property(e => e.datFechaInicio).HasColumnType("datetime");
            entity.Property(e => e.datFechaUltimaModificacion).HasColumnType("datetime");
        });

        modelBuilder.Entity<tblSesiones_Hist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblSesiones_Hist");

            entity.Property(e => e.datFechaInicio).HasColumnType("datetime");
            entity.Property(e => e.strIdSession).HasMaxLength(255);
        });

        modelBuilder.Entity<tblTPV>(entity =>
        {
            entity.HasKey(e => e.intTPV).HasFillFactor(90);

            entity.Property(e => e.intTPV).ValueGeneratedNever();
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strImpresora).HasMaxLength(50);
            entity.Property(e => e.strMotorPagos).HasMaxLength(50);
            entity.Property(e => e.strPC)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblTPVMenu>(entity =>
        {
            entity.HasKey(e => new { e.intMenu, e.intOrden, e.strOpcion }).HasFillFactor(90);

            entity.ToTable("tblTPVMenu");

            entity.Property(e => e.strOpcion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.strValor)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblTPVXDispensario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblTPVXDispensario");
        });

        modelBuilder.Entity<tblTankVirtualGlobal>(entity =>
        {
            entity.HasKey(e => e.intIdTanque).HasName("PK__tblTankV__57527F3FCDD93318");

            entity.ToTable("tblTankVirtualGlobal");

            entity.Property(e => e.strProducto).IsUnicode(false);
        });

        modelBuilder.Entity<tblTanque>(entity =>
        {
            entity.HasKey(e => e.intTanque).HasFillFactor(90);

            entity.Property(e => e.intTanque).ValueGeneratedNever();
            entity.Property(e => e.datFechaHora).HasColumnType("datetime");
            entity.Property(e => e.datFechaLectura).HasColumnType("datetime");
            entity.Property(e => e.dblTemperatura).HasDefaultValue(0.0, "DF_tblTanques_dblTemperatura");
            entity.Property(e => e.dblVolumenAgua).HasDefaultValue(0.0, "DF_tblTanques_dblVolumenAgua");
            entity.Property(e => e.dblVolumenRecepcion).HasDefaultValue(0.0, "DF_tblTanques_dblVolumenRecepcion");
            entity.Property(e => e.dblVolumenTC).HasDefaultValue(0.0, "DF_tblTanques_dblVolumenTC");
            entity.Property(e => e.dblVolumenTotal).HasDefaultValue(0.0, "DF_tblTanques_dblVolumenTotal");
            entity.Property(e => e.dblVolumenUtil).HasDefaultValue(0.0, "DF_tblTanques_dblVolumenUtil");
            entity.Property(e => e.dblVolumenVacio).HasDefaultValue(0.0, "DF_tblTanques_dblVolumenDisponible");
            entity.Property(e => e.strEstatus)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.HasOne(d => d.intProductoNavigation).WithMany(p => p.tblTanques)
                .HasForeignKey(d => d.intProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTanques_tblProductos");
        });

        modelBuilder.Entity<tblTanques_CV>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblTanques_CV");

            entity.Property(e => e.datFechaLectura).HasColumnType("datetime");
            entity.Property(e => e.datfechahora).HasColumnType("datetime");
            entity.Property(e => e.strFolioPemex)
                .HasMaxLength(10)
                .IsFixedLength()
                .UseCollation("Latin1_General_CI_AI");
        });

        modelBuilder.Entity<tblTanques_Hist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblTanques_Hist");

            entity.Property(e => e.datFechaHora).HasColumnType("datetime");
            entity.Property(e => e.datFechaLectura).HasColumnType("datetime");
            entity.Property(e => e.strEstatus)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblTerminale>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.intTerminal).ValueGeneratedOnAdd();
            entity.Property(e => e.strTerminal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strUsoPreferente).HasMaxLength(100);
        });

        modelBuilder.Entity<tblTerminalesBancaria>(entity =>
        {
            entity.HasKey(e => e.intTPV).HasName("PK_Terminal");

            entity.Property(e => e.intTPV).ValueGeneratedNever();
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strBaudRate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.strNoSerial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strParity)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblTiemposCV>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblTiemposCV");

            entity.Property(e => e.strHoraFin)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.strHoraIni)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblTipoComponente>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblTipoComponente");

            entity.Property(e => e.strNombre).HasMaxLength(255);
        });

        modelBuilder.Entity<tblTipoControl>(entity =>
        {
            entity.HasKey(e => e.intIDTipoControl);

            entity.ToTable("tblTipoControl");

            entity.Property(e => e.intIDTipoControl).ValueGeneratedNever();
            entity.Property(e => e.strDescription).HasMaxLength(50);
        });

        modelBuilder.Entity<tblTipoDespacho>(entity =>
        {
            entity.HasKey(e => e.intIDTipoDespacho);

            entity.ToTable("tblTipoDespacho");

            entity.Property(e => e.intIDTipoDespacho).ValueGeneratedNever();
            entity.Property(e => e.datFechaAlta).HasColumnType("datetime");
            entity.Property(e => e.strDescripcion).HasMaxLength(50);
        });

        modelBuilder.Entity<tblTipoDispositivo>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.strIdentificacion).HasMaxLength(50);
            entity.Property(e => e.strNombre).HasMaxLength(255);
        });

        modelBuilder.Entity<tblTipoMedicion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblTipoMedicion");
        });

        modelBuilder.Entity<tblTipoProcesoE>(entity =>
        {
            entity.HasKey(e => e.intID).HasName("PK__tblTipoP__11B67932ADE62A4E");

            entity.ToTable("tblTipoProcesoE");

            entity.Property(e => e.strTipoProceso).IsUnicode(false);
        });

        modelBuilder.Entity<tblTipoVentana>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblTipoVentana");

            entity.Property(e => e.strDescripcion).HasMaxLength(255);
        });

        modelBuilder.Entity<tblTiposAlmacen>(entity =>
        {
            entity.HasKey(e => e.intTipoAlmacen).HasFillFactor(90);

            entity.ToTable("tblTiposAlmacen");

            entity.Property(e => e.intTipoAlmacen).ValueGeneratedNever();
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblTiposArchivo>(entity =>
        {
            entity.HasKey(e => e.strTipo).HasFillFactor(90);

            entity.Property(e => e.strTipo)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblTiposDocumento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblTiposDocumento");

            entity.Property(e => e.strDescripcion)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.strTipoDocto)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblTiposDocumentoLiq>(entity =>
        {
            entity.HasKey(e => e.intTipoDocumento).HasFillFactor(90);

            entity.ToTable("tblTiposDocumentoLiq");

            entity.Property(e => e.intTipoDocumento).ValueGeneratedNever();
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblTiposMedidore>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.strDescripcion).HasMaxLength(50);
        });

        modelBuilder.Entity<tblTiposMovimientoInv>(entity =>
        {
            entity.HasKey(e => e.intTipoMovimiento)
                .HasName("PK_tblTiposMovimiento")
                .HasFillFactor(90);

            entity.ToTable("tblTiposMovimientoInv");

            entity.Property(e => e.intTipoMovimiento).ValueGeneratedNever();
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.strDescripcionCorta)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblTiposPago>(entity =>
        {
            entity.HasKey(e => e.intTipoVenta);

            entity.Property(e => e.intTipoVenta).ValueGeneratedNever();
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblTiposProducto>(entity =>
        {
            entity.HasKey(e => e.intTipoProducto).HasFillFactor(90);

            entity.ToTable("tblTiposProducto");

            entity.Property(e => e.intTipoProducto).ValueGeneratedNever();
            entity.Property(e => e.bitAgrupado).HasDefaultValue(true);
            entity.Property(e => e.datFechaAlta).HasColumnType("datetime");
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strUsuarioAlta)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblTiposServicio>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblTiposServicio");

            entity.Property(e => e.intIdTipoServicio).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<tblTiposTransaccion>(entity =>
        {
            entity.HasKey(e => e.intTipoTransaccion)
                .HasName("PK_tblTiposOperacion")
                .HasFillFactor(90);

            entity.ToTable("tblTiposTransaccion");

            entity.HasIndex(e => e.strTipoTransaccion, "IX_tblTiposOperacion")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.intTipoTransaccion).ValueGeneratedNever();
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.strTipoTransaccion)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblTiposVentum>(entity =>
        {
            entity.HasKey(e => e.intTipoVenta).HasFillFactor(90);

            entity.Property(e => e.intTipoVenta).ValueGeneratedNever();
            entity.Property(e => e.strControlPago).HasMaxLength(255);
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strValorControlPago).HasMaxLength(255);
        });

        modelBuilder.Entity<tblTokenUniversal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblTokenUniversal");

            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strIdentificador).HasMaxLength(50);
        });

        modelBuilder.Entity<tblTotalizadore>(entity =>
        {
            entity.HasKey(e => new { e.intFolioCorte, e.intDispensario, e.intManguera }).HasFillFactor(90);

            entity.Property(e => e.datFechaFinal).HasColumnType("datetime");
            entity.Property(e => e.datFechaInicio).HasColumnType("datetime");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();

            entity.HasOne(d => d.intFolioCorteNavigation).WithMany(p => p.tblTotalizadores)
                .HasForeignKey(d => d.intFolioCorte)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTotalizadores_tblFoliosCorte");

            entity.HasOne(d => d.intProductoNavigation).WithMany(p => p.tblTotalizadores)
                .HasForeignKey(d => d.intProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTotalizadores_tblProductos");

            entity.HasOne(d => d.tblManguera).WithMany(p => p.tblTotalizadores)
                .HasForeignKey(d => new { d.intDispensario, d.intManguera })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTotalizadores_tblMangueras");
        });

        modelBuilder.Entity<tblTotalizadoresManuale>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFechaAlta).HasColumnType("datetime");
            entity.Property(e => e.datFechaFinal).HasColumnType("datetime");
            entity.Property(e => e.datFechaInicio).HasColumnType("datetime");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strMaquinaAlta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strUsuarioAlta)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblTotalizadores_Copium>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFechaFinal).HasColumnType("datetime");
            entity.Property(e => e.datFechaInicio).HasColumnType("datetime");
        });

        modelBuilder.Entity<tblTotalizadorxDi>(entity =>
        {
            entity.HasKey(e => e.intID).HasName("PK__tblTotal__11B679321F50D1CA");

            entity.Property(e => e.datFechaAlta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.dblTotalizadorFin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.dblTotalizadorIni).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<tblTranMonedero>(entity =>
        {
            entity.HasKey(e => e.intID).HasName("PK__tblTranM__11B679323973DA80");

            entity.ToTable("tblTranMonedero");

            entity.Property(e => e.datFechaAlta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.strUsuarioAlta).IsUnicode(false);
        });

        modelBuilder.Entity<tblTranRecepcionCV>(entity =>
        {
            entity.HasKey(e => e.intID).HasName("PK__tblTranR__11B67932CDC35362");

            entity.ToTable("tblTranRecepcionCV");

            entity.Property(e => e.datFechaAlta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.dblTemperatura).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.dblVolumenB).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.dblVolumenN).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<tblTransaccione>(entity =>
        {
            entity.HasKey(e => new { e.intFolioCorte, e.intTransaccion }).HasFillFactor(90);

            entity.HasIndex(e => e.datFechahora, "Fecha");

            entity.HasIndex(e => e.dblImporte, "IDX_Transac_Importe");

            entity.HasIndex(e => new { e.intFolioCorte, e.intDispensario, e.intManguera }, "IX_tblTransaccionesCorte").HasFillFactor(90);

            entity.HasIndex(e => e.intTransaccion, "IX_tblTransacciones_intTransaccion");

            entity.HasIndex(e => e.datFechahora, "idxTrxFecProdPrecio");

            entity.HasIndex(e => new { e.intDispensario, e.intImpresion }, "idx_ImprimeTicket");

            entity.HasIndex(e => e.intProducto, "idx_Monitor");

            entity.HasIndex(e => e.datFechahora, "idx_Monitor_2");

            entity.HasIndex(e => e.intDispensario, "idx_Trx");

            entity.HasIndex(e => e.dblImporte, "idx_VIWLiquidaTRXDesp");

            entity.HasIndex(e => new { e.intFolioCorte, e.intTipoVenta }, "idx_tranv3");

            entity.HasIndex(e => new { e.intFolioCorte, e.intTipoVenta }, "idx_tranv4");

            entity.HasIndex(e => e.intSecuencia, "intSecuencia").IsUnique();

            entity.Property(e => e.datFechahora).HasColumnType("datetime");
            entity.Property(e => e.dblTemperatura).HasColumnType("decimal(20, 3)");
            entity.Property(e => e.intFolioLote).HasDefaultValue(0L, "DF_tblTransacciones_intFolioLote");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strBandaMagnetica)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strCliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strFacturaCodigoCliente).HasMaxLength(50);
            entity.Property(e => e.strLetraFolio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strOdometro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPie1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strRendimiento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strRfcCliente).HasMaxLength(100);
            entity.Property(e => e.strTarjeta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strTipoTransaccion)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.strTotalizadorFinal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strVehiculo)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.intDispensarioNavigation).WithMany(p => p.tblTransacciones)
                .HasForeignKey(d => d.intDispensario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTransacciones_tblDispensarios");

            entity.HasOne(d => d.intFolioCorteNavigation).WithMany(p => p.tblTransacciones)
                .HasForeignKey(d => d.intFolioCorte)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTransacciones_tblCortes");

            entity.HasOne(d => d.intProductoNavigation).WithMany(p => p.tblTransacciones)
                .HasForeignKey(d => d.intProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTransacciones_tblProductos");

            entity.HasOne(d => d.intTPVNavigation).WithMany(p => p.tblTransacciones)
                .HasForeignKey(d => d.intTPV)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTransacciones_tblTPVs");

            entity.HasOne(d => d.intTipoVentaNavigation).WithMany(p => p.tblTransacciones)
                .HasForeignKey(d => d.intTipoVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTransacciones_tblTiposVenta");

            entity.HasOne(d => d.intUsuarioNavigation).WithMany(p => p.tblTransacciones)
                .HasForeignKey(d => d.intUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTransacciones_tblEmpleados");

            entity.HasOne(d => d.strTipoTransaccionNavigation).WithMany(p => p.tblTransacciones)
                .HasPrincipalKey(p => p.strTipoTransaccion)
                .HasForeignKey(d => d.strTipoTransaccion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTransacciones_tblTiposTransaccion");

            entity.HasOne(d => d.tblManguera).WithMany(p => p.tblTransacciones)
                .HasForeignKey(d => new { d.intDispensario, d.intManguera })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblTransacciones_tblMangueras");
        });

        modelBuilder.Entity<tblTransaccionesBancaria>(entity =>
        {
            entity.HasKey(e => e.ApprovalCode);

            entity.Property(e => e.ApprovalCode).HasMaxLength(50);
            entity.Property(e => e.AID).HasMaxLength(50);
            entity.Property(e => e.ALabel).HasMaxLength(50);
            entity.Property(e => e.APN).HasMaxLength(50);
            entity.Property(e => e.ARQC).HasMaxLength(50);
            entity.Property(e => e.Account).HasMaxLength(50);
            entity.Property(e => e.Afiliado).HasMaxLength(50);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Autoriz).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(50);
            entity.Property(e => e.BanorteReference).HasMaxLength(50);
            entity.Property(e => e.BrandName).HasMaxLength(50);
            entity.Property(e => e.CardExpiration).HasMaxLength(50);
            entity.Property(e => e.CardHolderName).HasMaxLength(50);
            entity.Property(e => e.CardName).HasMaxLength(50);
            entity.Property(e => e.CardTypeName).HasMaxLength(50);
            entity.Property(e => e.ControlNumber).HasMaxLength(50);
            entity.Property(e => e.ErrorMessage).HasMaxLength(500);
            entity.Property(e => e.MaskedAccount).HasMaxLength(50);
            entity.Property(e => e.MerchantID).HasMaxLength(50);
            entity.Property(e => e.ResponseCode).HasMaxLength(50);
            entity.Property(e => e.ResponseMessage).HasMaxLength(50);
            entity.Property(e => e.Saldo).HasColumnType("money");
            entity.Property(e => e.SmartReference).HasMaxLength(50);
            entity.Property(e => e.TSI).HasMaxLength(50);
            entity.Property(e => e.TVR).HasMaxLength(50);
            entity.Property(e => e.Tarjeta).HasMaxLength(50);
            entity.Property(e => e.Terminal).HasMaxLength(50);
            entity.Property(e => e.TerminalID).HasMaxLength(50);
            entity.Property(e => e.TerminalSerialNumber).HasMaxLength(50);
            entity.Property(e => e.Tip).HasColumnType("money");
            entity.Property(e => e.TipoTarjeta).HasMaxLength(50);
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.Transaccion).HasMaxLength(50);
            entity.Property(e => e.TransaccionOrigen).HasMaxLength(50);
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<tblTransaccionesConsola>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__tblTrans__3214EC27BA265C5D");

            entity.ToTable("tblTransaccionesConsola");

            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.dblMonto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.dblMontoProgramado).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.dblPrecio).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.dblTemperatura).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.dblVolumen).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.decTotalizadorFinal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.strObservaciones).HasMaxLength(500);
        });

        modelBuilder.Entity<tblTransaccionesDetV2>(entity =>
        {
            entity.HasKey(e => new { e.intTransaccion, e.intMovimiento });

            entity.ToTable("tblTransaccionesDetV2");

            entity.HasIndex(e => e.intTransaccion, "idx_TransaccionesDetV2_Tran_FP");

            entity.HasIndex(e => e.intTransaccion, "idx_Tranv2");

            entity.Property(e => e.decImporte).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.strBandaMagnetica)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strCliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strOdometro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPie1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strTarjeta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strVehiculo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblTransaccionesDetV2_Historium>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.decImporte).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.strBandaMagnetica)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strCliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strIdMovimiento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strMotivoEliminado).HasColumnType("text");
            entity.Property(e => e.strOdometro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPie1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strTarjeta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strVehiculo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblTransaccionesDet_FormaPago>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblTransaccionesDet_FormaPago");

            entity.Property(e => e.datFechaHora).HasColumnType("datetime");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblTransaccionesDolare>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFechaContable).HasColumnType("datetime");
        });

        modelBuilder.Entity<tblTransaccionesPinPad>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblTransaccionesPinPad");

            entity.HasIndex(e => e.intTransaccion, "IX_tblTransaccionesPinPad").IsClustered();

            entity.Property(e => e.datFechaAlta).HasColumnType("datetime");
            entity.Property(e => e.decMonto).HasColumnType("decimal(22, 2)");
            entity.Property(e => e.decPropina).HasColumnType("decimal(22, 2)");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<tblTransaccionesServicio>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFechahora).HasColumnType("datetime");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strAutorizacion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strBandaMagnetica)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strCompania)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strLetraFolio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strLeyenda)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strMonto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strPie1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strPie2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strPie3)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strPie4)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strReferencia)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strTarjeta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strTipoTransaccion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strVehiculo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblTransaccionesVario>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.intDispensario, e.intTipoProducto }, "IDX_TranVarXTransacc");

            entity.HasIndex(e => new { e.datFechahora, e.intProducto }, "IDX_tblTransaccionesVarios");

            entity.HasIndex(e => e.intFolioCorte, "IDX_tblTransaccionesVarios_FC");

            entity.HasIndex(e => new { e.intDispensario, e.intTipoProducto }, "idx_DispensarioTipoProducto");

            entity.HasIndex(e => e.intTransaccion, "idx_Transaccion");

            entity.Property(e => e.datFechahora).HasColumnType("datetime");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strBandaMagnetica)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strFacturaCodigoCliente).HasMaxLength(50);
            entity.Property(e => e.strLetraFolio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPie1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strPie2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strPie3)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strPie4)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strTarjeta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strTipoTransaccion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strVehiculo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblTransaccionesVarios_Detalle>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.datFechaHora, "IX_tblTransaccionesVarios_Detalles_datFechaHora");

            entity.Property(e => e.datFechaHora).HasColumnType("datetime");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<tblTransacciones_Eliminado>(entity =>
        {
            entity.HasKey(e => e.intID).HasName("PK__tblTrans__11B67932CB219290");

            entity.Property(e => e.intID).ValueGeneratedNever();
            entity.Property(e => e.datFechaEliminado).HasColumnType("datetime");
            entity.Property(e => e.datFechahora).HasColumnType("datetime");
            entity.Property(e => e.strBandaMagnetica)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strCliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strFacturaCodigoCliente)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strLetraFolio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strMotivoEliminado).HasColumnType("text");
            entity.Property(e => e.strOdometro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPie1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strRendimiento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strTarjeta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strTipoTransaccion)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.strToken)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strTotalizadorFinal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strVehiculo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblTransacciones_Historium>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFechahora).HasColumnType("datetime");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strBandaMagnetica)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strCliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strLetraFolio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strOdometro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPie1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strTarjeta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strTipoTransaccion)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.strVehiculo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblTransacciones_NOENVIADA>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblTransacciones_NOENVIADAS");

            entity.Property(e => e.datFechahora).HasColumnType("datetime");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strBandaMagnetica)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strCliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strLetraFolio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strOdometro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPie1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strTarjeta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strTipoTransaccion)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.strVehiculo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblTransacciones_Promocione>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.intID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<tblTransportesCV>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblTransportesCV");

            entity.Property(e => e.strPermisoTransporte).HasMaxLength(50);
            entity.Property(e => e.strTipoTransporte).HasMaxLength(50);
        });

        modelBuilder.Entity<tblTurno>(entity =>
        {
            entity.HasKey(e => e.intTurno).HasFillFactor(90);

            entity.Property(e => e.intTurno).ValueGeneratedNever();
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblUATransaccionUUID>(entity =>
        {
            entity.HasKey(e => e.intTransaccion).HasName("PK__tblUATra__F4C5F9E398CE02A9");

            entity.ToTable("tblUATransaccionUUID");

            entity.Property(e => e.intTransaccion).ValueGeneratedNever();
            entity.Property(e => e.datFecha).HasColumnType("datetime");
            entity.Property(e => e.datFechaAlta).HasColumnType("datetime");
            entity.Property(e => e.datFechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.dblCantidad).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.dblImporte).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.dblTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.intIdTransaccionUUID).ValueGeneratedOnAdd();
            entity.Property(e => e.strDV)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.strRFCEmisor)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.strRFCReceptor)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.strSerie)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.strUUID)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblUAV2_ConexionEndpoint>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblUAV2_ConexionEndpoint");

            entity.Property(e => e.Endpoint).HasMaxLength(150);
            entity.Property(e => e.Evento).HasMaxLength(50);
            entity.Property(e => e.IP).HasMaxLength(50);
            entity.Property(e => e.LogDate)
                .HasDefaultValueSql("(getdate())", "DF_tblUAV2_ConexionEndpoint_LogDate")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<tblUAV2_ErrorLog>(entity =>
        {
            entity.HasKey(e => e.LogID);

            entity.ToTable("tblUAV2_ErrorLog");

            entity.Property(e => e.LogID).HasDefaultValueSql("(newid())", "DF_tblUAV2_ErrorLog_LogID");
            entity.Property(e => e.Estacion).HasMaxLength(50);
            entity.Property(e => e.LogDate).HasColumnType("datetime");
            entity.Property(e => e.Mensaje).HasMaxLength(500);
            entity.Property(e => e.TerminalSerie).HasMaxLength(50);
            entity.Property(e => e.TerminalVersion).HasMaxLength(50);
        });

        modelBuilder.Entity<tblUAV2_EstatusDispensario>(entity =>
        {
            entity.HasKey(e => e.LogID);

            entity.ToTable("tblUAV2_EstatusDispensario");

            entity.Property(e => e.LogID).HasDefaultValueSql("(newid())", "DF_tblUAV2_EstatusDispensario_LogID");
            entity.Property(e => e.LogDate)
                .HasDefaultValueSql("(getdate())", "DF_tblUAV2_EstatusDispensario_LogDate")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<tblUAV2_GoBenefit>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AcumulacionUrl).HasMaxLength(250);
            entity.Property(e => e.Cantidad).HasMaxLength(50);
            entity.Property(e => e.CantidadBoletos).HasMaxLength(50);
            entity.Property(e => e.Descuento).HasMaxLength(50);
            entity.Property(e => e.Excepcion).HasMaxLength(500);
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())", "DF_tblIUAV2_GoBenefits_Fecha")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.Mensaje).HasMaxLength(500);
            entity.Property(e => e.Monto).HasMaxLength(50);
            entity.Property(e => e.ProductoID).HasMaxLength(50);
            entity.Property(e => e.Puntos).HasMaxLength(50);
            entity.Property(e => e.Saldo).HasMaxLength(50);
            entity.Property(e => e.TipoBoletos).HasMaxLength(50);
            entity.Property(e => e.TipoVenta).HasMaxLength(50);
            entity.Property(e => e.Transaccion).HasMaxLength(50);
        });

        modelBuilder.Entity<tblUAV2_GoBenefitsAppLog>(entity =>
        {
            entity.HasKey(e => e.LogID);

            entity.ToTable("tblUAV2_GoBenefitsAppLog");

            entity.Property(e => e.LogID).HasDefaultValueSql("(newid())", "DF_tblUAV2_GoBenefitsAppLog_LogID");
            entity.Property(e => e.Accion).HasMaxLength(150);
            entity.Property(e => e.EmpleadoID).HasMaxLength(150);
            entity.Property(e => e.EmpleadoNombre).HasMaxLength(150);
            entity.Property(e => e.Estacion).HasMaxLength(150);
            entity.Property(e => e.FormasPago).HasMaxLength(2000);
            entity.Property(e => e.GBTerminalID).HasMaxLength(150);
            entity.Property(e => e.LogDate).HasColumnType("datetime");
            entity.Property(e => e.ProductoID).HasMaxLength(150);
            entity.Property(e => e.ProductoNombre).HasMaxLength(150);
            entity.Property(e => e.TerminalSerie).HasMaxLength(150);
            entity.Property(e => e.TerminalVersion).HasMaxLength(150);
            entity.Property(e => e.Transaccion).HasMaxLength(150);
        });

        modelBuilder.Entity<tblUAV2_Opcion>(entity =>
        {
            entity.HasKey(e => e.OpcionID);

            entity.ToTable("tblUAV2_Opcion");

            entity.Property(e => e.OpcionID).ValueGeneratedNever();
            entity.Property(e => e.Etiqueta).HasMaxLength(50);
            entity.Property(e => e.Llave).HasMaxLength(50);
        });

        modelBuilder.Entity<tblUAV2_PagoTerminal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblUAV2_PagoTerminal");

            entity.Property(e => e.Estacion).HasMaxLength(150);
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())", "DF_tblUAV2_PagoTerminal_Fecha")
                .HasColumnType("datetime");
            entity.Property(e => e.Importe).HasColumnType("money");
            entity.Property(e => e.Mensaje).HasMaxLength(500);
            entity.Property(e => e.PagoID).HasDefaultValueSql("(newid())", "DF_tblUAV2_PagoTerminal_PagoID");
            entity.Property(e => e.TerminalSerie).HasMaxLength(150);
            entity.Property(e => e.TerminalVersion).HasMaxLength(150);
        });

        modelBuilder.Entity<tblUAV2_RetoMobil>(entity =>
        {
            entity.HasKey(e => new { e.intTransaccion, e.intTipo }).HasName("PK_tblUAV2_RetoMobilCheckIn");

            entity.ToTable("tblUAV2_RetoMobil");

            entity.Property(e => e.datFechaHora)
                .HasDefaultValueSql("(getdate())", "DF_tblUAV2_RetoMobilCheckIn_FechaCheckIn")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<tblUAV2_Sesione>(entity =>
        {
            entity.HasKey(e => e.SesionID);

            entity.Property(e => e.SesionID).HasDefaultValueSql("(newid())", "DF_tblUAV2_Sesiones_SesionID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.TerminalClave).HasMaxLength(50);
            entity.Property(e => e.TerminalSerie).HasMaxLength(50);
            entity.Property(e => e.TerminalVersion).HasMaxLength(50);
        });

        modelBuilder.Entity<tblUAV2_SolicitudAutorizacion>(entity =>
        {
            entity.HasKey(e => e.SolicitudID);

            entity.ToTable("tblUAV2_SolicitudAutorizacion");

            entity.Property(e => e.SolicitudID).HasDefaultValueSql("(newid())", "DF_tblUAV2_SolicitudAutorizacion_SolicitudID");
            entity.Property(e => e.CheckIn).HasMaxLength(50);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaAutorizacion).HasColumnType("datetime");
            entity.Property(e => e.Litros).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Mensaje).HasMaxLength(1000);
            entity.Property(e => e.NumeroEstacion).HasMaxLength(50);
            entity.Property(e => e.Pesos).HasColumnType("money");
            entity.Property(e => e.Serie).HasMaxLength(100);
            entity.Property(e => e.URL).HasMaxLength(500);
        });

        modelBuilder.Entity<tblUAV2_TokaPago>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblUAV2_TokaPago");

            entity.Property(e => e.datFechaHora).HasColumnType("datetime");
            entity.Property(e => e.dblMonto)
                .HasDefaultValue(0m, "DF_tblUAV2_TokaPago_dblMonto")
                .HasColumnType("money");
            entity.Property(e => e.idAutorizacion).HasMaxLength(100);
            entity.Property(e => e.idRespuesta).HasMaxLength(100);
            entity.Property(e => e.strMotivoFallo).HasMaxLength(500);
        });

        modelBuilder.Entity<tblUAV2_WSHelperLog>(entity =>
        {
            entity.HasKey(e => e.LogID);

            entity.ToTable("tblUAV2_WSHelperLog");

            entity.Property(e => e.LogID).HasDefaultValueSql("(newid())", "DF_tblUAV2_WSHelperLog_LogID");
            entity.Property(e => e.DateEnd).HasColumnType("datetime");
            entity.Property(e => e.DateStart).HasColumnType("datetime");
            entity.Property(e => e.Estacion).HasMaxLength(150);
            entity.Property(e => e.Listener).HasMaxLength(150);
            entity.Property(e => e.LogDate)
                .HasDefaultValueSql("(getdate())", "DF_tblUAV2_WSHelperLog_LogDate")
                .HasColumnType("datetime");
            entity.Property(e => e.Method).HasMaxLength(500);
            entity.Property(e => e.RequestMethod).HasMaxLength(50);
            entity.Property(e => e.TerminalSerie).HasMaxLength(150);
            entity.Property(e => e.TerminalVersion).HasMaxLength(150);
            entity.Property(e => e.URL).HasMaxLength(500);
        });

        modelBuilder.Entity<tblUltimosPassword>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFechaHora).HasColumnType("datetime");
            entity.Property(e => e.id).ValueGeneratedOnAdd();
            entity.Property(e => e.strPassword).HasMaxLength(128);
            entity.Property(e => e.strUser)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblUsuario>(entity =>
        {
            entity.HasKey(e => e.intUsuario)
                .HasName("PK_tblEmpleados")
                .HasFillFactor(90);

            entity.Property(e => e.intUsuario).ValueGeneratedNever();
            entity.Property(e => e.datFechaAlta).HasColumnType("datetime");
            entity.Property(e => e.datFechaBaja).HasColumnType("datetime");
            entity.Property(e => e.datFechaMod).HasColumnType("datetime");
            entity.Property(e => e.datFechaUltimoCambioPassword).HasColumnType("datetime");
            entity.Property(e => e.datFechaUltimoLogin).HasColumnType("datetime");
            entity.Property(e => e.strAMaterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strAPaterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strEstatus)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.strIdentificador)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPassword).HasMaxLength(8000);
            entity.Property(e => e.strPasswordTPV)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strRFID).IsUnicode(false);
            entity.Property(e => e.strUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strUsuarioAlta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strUsuarioBaja)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strUsuarioMod)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblUsuarioIsla>(entity =>
        {
            entity.HasKey(e => new { e.intFolioCorte, e.intUsuario, e.intIsla }).HasFillFactor(90);

            entity.ToTable("tblUsuarioIsla");

            entity.Property(e => e.datFechaAlta).HasColumnType("datetime");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();

            entity.HasOne(d => d.intFolioCorteNavigation).WithMany(p => p.tblUsuarioIslas)
                .HasForeignKey(d => d.intFolioCorte)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblUsuarioIsla_tblFoliosCorte");

            entity.HasOne(d => d.intIslaNavigation).WithMany(p => p.tblUsuarioIslas)
                .HasForeignKey(d => d.intIsla)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblUsuarioIsla_tblIslas");

            entity.HasOne(d => d.intUsuarioNavigation).WithMany(p => p.tblUsuarioIslas)
                .HasForeignKey(d => d.intUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblUsuarioIsla_tblUsuarios");
        });

        modelBuilder.Entity<tblUsuarioIslaProgramado>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFechaAlta).HasColumnType("datetime");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<tblUsuariosDi>(entity =>
        {
            entity.HasKey(e => e.intID).HasName("PK__tblUsuar__11B67932608A5C28");

            entity.Property(e => e.datFechaAlta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.strUsuarioAlta).IsUnicode(false);
        });

        modelBuilder.Entity<tblUsuariosGrupo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblUsuariosGrupo");
        });

        modelBuilder.Entity<tblUsuariosStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblUsuariosStatus");

            entity.Property(e => e.strDescripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strEstatus)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblVentasCV>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblVentasCV");

            entity.Property(e => e.DETALLE)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FECHAHORAGENERADO)
                .HasMaxLength(22)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblWSSEP>(entity =>
        {
            entity.HasKey(e => e.intID).HasName("PK__tblWSSEP__11B6793287E562D0");

            entity.ToTable("tblWSSEP");

            entity.Property(e => e.strProducto)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblWSSEp_Transaccione>(entity =>
        {
            entity.HasKey(e => e.intID).HasName("PK__tblWSSEp__11B67932F2CE418E");

            entity.Property(e => e.datFecha).HasColumnType("datetime");
            entity.Property(e => e.datFechaAlta).HasColumnType("datetime");
            entity.Property(e => e.dblDencidad).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.strClaveVehiculo)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.strPermisoAlma)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.strPermisoTrans)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tbl_CP_PreciosProgramado>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.datFechaProgramada, e.strStatus }, "IX_tbl_CP_PreciosProgramados_datFechaProgramada_strStatus");

            entity.Property(e => e.datFechaAlta).HasColumnType("datetime");
            entity.Property(e => e.datFechaEnvioAEstacion).HasColumnType("datetime");
            entity.Property(e => e.datFechaEnvioANexgen).HasColumnType("datetime");
            entity.Property(e => e.datFechaProgramada).HasColumnType("datetime");
            entity.Property(e => e.datFechaVerificacionPrecio).HasColumnType("datetime");
            entity.Property(e => e.datFechaVigencia).HasColumnType("datetime");
            entity.Property(e => e.strEstacion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.strMaquinaAlta)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.strStatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("1");
            entity.Property(e => e.strUsuarioAlta)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblprocesopasomanager_jul14_2025>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblprocesopasomanager_jul14_2025");
        });

        modelBuilder.Entity<tblprocesopasomanager_mar01_2025>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblprocesopasomanager_mar01_2025");
        });

        modelBuilder.Entity<tblpromociones_detalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblpromociones_detalle");
        });

        modelBuilder.Entity<tblserviciosweb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblserviciosweb");

            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strLlaveServicio)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.strNombreServicio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strParametros)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strURLServicio)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tbltransacciones_ERROR>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbltransacciones_ERROR");

            entity.Property(e => e.datFechahora).HasColumnType("datetime");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strBandaMagnetica)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strCliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strLetraFolio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strOdometro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPie1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strTarjeta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strTipoTransaccion)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.strVehiculo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tbltransacciones_eliminada>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.datFechahora).HasColumnType("datetime");
            entity.Property(e => e.strBandaMagnetica)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strCliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strLetraFolio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strOdometro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPie1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strTarjeta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strTipoTransaccion)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.strVehiculo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tmpRecepcionesCV>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpRecepcionesCV");

            entity.Property(e => e.FECHAHORAGNAARC)
                .HasMaxLength(22)
                .IsUnicode(false);
            entity.Property(e => e.FechaDocto)
                .HasMaxLength(22)
                .IsUnicode(false);
            entity.Property(e => e.FechaRecepcion)
                .HasMaxLength(22)
                .IsUnicode(false);
            entity.Property(e => e.FolioDocto)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.RFC)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.SIIC)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tanque)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Temperatura).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Terminal)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocto)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TipoRegistro)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Vehiculo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.VolumenDocto).HasColumnType("decimal(13, 3)");
            entity.Property(e => e.VolumenFinal).HasColumnType("decimal(13, 3)");
            entity.Property(e => e.VolumenInicial).HasColumnType("decimal(13, 3)");
            entity.Property(e => e.VolumenRecepcion).HasColumnType("decimal(13, 3)");
        });

        modelBuilder.Entity<tmpVentas1CV>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpVentas1CV");

            entity.Property(e => e.Cabecera)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.FECHAHORAGNAARC)
                .HasMaxLength(22)
                .IsUnicode(false);
            entity.Property(e => e.FechaTransaccion)
                .HasMaxLength(22)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.RFC)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.SIIC)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Volumen)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(13, 3)");
            entity.Property(e => e.dblImporte)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(13, 3)");
            entity.Property(e => e.dblPrecioUnitario)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(7, 3)");
            entity.Property(e => e.intDispensario)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.intManguera)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tmpVentasCV>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpVentasCV");

            entity.Property(e => e.Cabecera)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.FECHAHORAGNAARC)
                .HasMaxLength(22)
                .IsUnicode(false);
            entity.Property(e => e.FechaTransaccion)
                .HasMaxLength(22)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.RFC)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.SIIC)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Volumen)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(13, 3)");
            entity.Property(e => e.dblImporte)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(13, 3)");
            entity.Property(e => e.dblPrecioUnitario)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(7, 3)");
            entity.Property(e => e.intDispensario)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.intManguera)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viwCorte_CorteAnteriorLiquidado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwCorte_CorteAnteriorLiquidado");
        });

        modelBuilder.Entity<viwLiquidacion_CapturaManualTransacciones_Producto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_CapturaManualTransacciones_Productos");

            entity.Property(e => e.strDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viwLiquidacion_CapturaManualTransacciones_TPV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_CapturaManualTransacciones_TPVs");
        });

        modelBuilder.Entity<viwLiquidacion_CapturaManualTransacciones_Transaccione>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_CapturaManualTransacciones_Transacciones");

            entity.Property(e => e.datFechahora).HasColumnType("datetime");
            entity.Property(e => e.strNombreCompleto)
                .HasMaxLength(152)
                .IsUnicode(false);
            entity.Property(e => e.strProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viwLiquidacion_CapturaManualTransacciones_Usuario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_CapturaManualTransacciones_Usuarios");

            entity.Property(e => e.strAMaterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strAPaterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strIdentificador)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viwLiquidacion_CortesXLiquidar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_CortesXLiquidar");

            entity.Property(e => e.datFechaContable).HasColumnType("datetime");
            entity.Property(e => e.datFechaFinal).HasColumnType("datetime");
            entity.Property(e => e.datFechaInicial).HasColumnType("datetime");
            entity.Property(e => e.datFechaLiquidacion).HasColumnType("datetime");
        });

        modelBuilder.Entity<viwLiquidacion_DispensariosXCortar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_DispensariosXCortar");
        });

        modelBuilder.Entity<viwLiquidacion_Inventarios_Detalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_Inventarios_Detalle");

            entity.Property(e => e.Almacen)
                .HasMaxLength(63)
                .IsUnicode(false);
            entity.Property(e => e.Existencia_Almacen).HasColumnName("Existencia Almacen");
            entity.Property(e => e.Existencia_Estacion).HasColumnName("Existencia Estacion");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Movimiento)
                .HasMaxLength(93)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(63)
                .IsUnicode(false);
            entity.Property(e => e.Referencia)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Usuario_Captura)
                .HasMaxLength(209)
                .IsUnicode(false)
                .HasColumnName("Usuario Captura");
            entity.Property(e => e.datFecha).HasColumnType("datetime");
            entity.Property(e => e.strAlmacen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.strMovimiento)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.strNombreUsuario)
                .HasMaxLength(152)
                .IsUnicode(false);
            entity.Property(e => e.strPC)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strReferencia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strTipoMovimiento)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.strUsuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viwLiquidacion_LiquidacionesXFecha>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_LiquidacionesXFecha");

            entity.Property(e => e.strDespachador)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.strDespachadores)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.strFecha)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.strFechaContable)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.strLiquidador)
                .HasMaxLength(152)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viwLiquidacion_MovimientosInventario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_MovimientosInventario");

            entity.Property(e => e.strDescripcion)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.strTM)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.strTipoMovimiento)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viwLiquidacion_MovimientosInventario_Ajuste>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_MovimientosInventario_Ajustes");

            entity.Property(e => e.datFecha).HasColumnType("datetime");
            entity.Property(e => e.strCapturo)
                .HasMaxLength(213)
                .IsUnicode(false);
            entity.Property(e => e.strCausa)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.strMovimiento)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.strProducto).HasMaxLength(114);
            entity.Property(e => e.strReferencia)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viwLiquidacion_Producto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_Productos");

            entity.Property(e => e.strDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPresentacion)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.strTipoProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viwLiquidacion_Productos_AditYLub>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_Productos_AditYLub");

            entity.Property(e => e.strCodigoBarras)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPresentacion)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.strProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strTipoProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viwLiquidacion_TotalTotalizadoresXDespachador>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_TotalTotalizadoresXDespachador");

            entity.Property(e => e.strAMaterno)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.strAPaterno)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.strNombre)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.strNombreCompleto)
                .HasMaxLength(13)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viwLiquidacion_TotalTotalizadoresXIsla>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_TotalTotalizadoresXIsla");
        });

        modelBuilder.Entity<viwLiquidacion_TotalTransaccione>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_TotalTransacciones");
        });

        modelBuilder.Entity<viwLiquidacion_TotalTransaccionesXDespachador>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_TotalTransaccionesXDespachador");

            entity.Property(e => e.strAMaterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strAPaterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strNombreCompleto)
                .HasMaxLength(152)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viwLiquidacion_TotalTransaccionesXDespachador_Manual>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_TotalTransaccionesXDespachador_Manual");

            entity.Property(e => e.strAMaterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strAPaterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strNombreCompleto)
                .HasMaxLength(152)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viwLiquidacion_TotalTransaccionesXDespachador_Transaccione>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_TotalTransaccionesXDespachador_Transacciones");

            entity.Property(e => e.strAMaterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strAPaterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strNombreCompleto)
                .HasMaxLength(152)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viwLiquidacion_TotalTransaccionesXDespachador_TransaccionesVario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_TotalTransaccionesXDespachador_TransaccionesVarios");

            entity.Property(e => e.strAMaterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strAPaterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strNombreCompleto)
                .HasMaxLength(152)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viwLiquidacion_TotalTransaccionesXIsla>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_TotalTransaccionesXIsla");
        });

        modelBuilder.Entity<viwLiquidacion_TotalXLiquidar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_TotalXLiquidar");
        });

        modelBuilder.Entity<viwLiquidacion_TotalesXFecha>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_TotalesXFecha");

            entity.Property(e => e.strFecha)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viwLiquidacion_Totalizadore>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_Totalizadores");

            entity.Property(e => e.datFechaFinal).HasColumnType("datetime");
            entity.Property(e => e.datFechaInicio).HasColumnType("datetime");
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viwLiquidacion_UA_TotalXLiquidar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_UA_TotalXLiquidar");
        });

        modelBuilder.Entity<viwLiquidacion_XCorte>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_XCorte");

            entity.Property(e => e.datFechaFinal).HasColumnType("datetime");
            entity.Property(e => e.value)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AI");
        });

        modelBuilder.Entity<viwLiquidacion_tblLiquidacionDetPago>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_tblLiquidacionDetPagos");
        });

        modelBuilder.Entity<viwLiquidacion_tblLiquidacionDetPagosAjuste>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_tblLiquidacionDetPagosAjuste");

            entity.Property(e => e.datFechaCaptura).HasColumnType("datetime");
            entity.Property(e => e.strAbreviatura)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.strCapturo)
                .HasMaxLength(213)
                .IsUnicode(false);
            entity.Property(e => e.strFormaPago)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strMoneda)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.strTipoVenta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strUsuarioCaptura)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viwLiquidacion_tblLiquidacionDetPagos_SEL>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_tblLiquidacionDetPagos_SEL");

            entity.Property(e => e.strAbreviatura)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.strMoneda)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.strNombreCorto)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.strTipoVenta)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viwLiquidacion_tblLiquidacionDetPagos_TOTAL>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_tblLiquidacionDetPagos_TOTAL");
        });

        modelBuilder.Entity<viwLiquidacion_tblLiquidacionDetPagos_UNION>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_tblLiquidacionDetPagos_UNION");
        });

        modelBuilder.Entity<viwLiquidacion_tblLiquidacionDetProd>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_tblLiquidacionDetProd");
        });

        modelBuilder.Entity<viwLiquidacion_tblLiquidacionDetProdAjuste>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_tblLiquidacionDetProdAjuste");

            entity.Property(e => e.datFechaCaptura).HasColumnType("datetime");
            entity.Property(e => e.strCapturo)
                .HasMaxLength(213)
                .IsUnicode(false);
            entity.Property(e => e.strPCCaptura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strProducto).HasMaxLength(114);
            entity.Property(e => e.strUsuarioCaptura)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viwLiquidacion_tblLiquidacionDetProd_SEL>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_tblLiquidacionDetProd_SEL");

            entity.Property(e => e.strProducto).HasMaxLength(114);
        });

        modelBuilder.Entity<viwLiquidacion_tblLiquidacionDetProd_TOTAL>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_tblLiquidacionDetProd_TOTAL");
        });

        modelBuilder.Entity<viwLiquidacion_tblLiquidacionDetProd_UAStock_SEL>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_tblLiquidacionDetProd_UAStock_SEL");

            entity.Property(e => e.strProducto)
                .HasMaxLength(454)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
        });

        modelBuilder.Entity<viwLiquidacion_tblLiquidacionDetProd_UNION>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_tblLiquidacionDetProd_UNION");
        });

        modelBuilder.Entity<viwLiquidacion_tblLiquidacionEnc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwLiquidacion_tblLiquidacionEnc");

            entity.Property(e => e.datFechaCaptura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.datFechaLiquidacion).HasColumnType("datetime");
            entity.Property(e => e.strDespachadores)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.strLiquidador)
                .HasMaxLength(152)
                .IsUnicode(false);
            entity.Property(e => e.strNombreUsuario)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.strPCCaptura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strUsuarioCaptura)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viwTPV_Dispensario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwTPV_Dispensarios");
        });

        modelBuilder.Entity<viwTPV_Producto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwTPV_Productos");

            entity.Property(e => e.strDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viwTPV_UsuariosActivo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viwTPV_UsuariosActivos");

            entity.Property(e => e.strAMaterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strAPaterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strIdentificador)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viw_CICAlarma>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viw_CICAlarmas");

            entity.Property(e => e.strAlarma)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.strNomCategoria)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strNomTipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strTipo)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viw_Liquidacion_Rep>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viw_Liquidacion_Rep");

            entity.Property(e => e.DescProd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DespachadoresIsla)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.FormaPago)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioIsla)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e._Usuario).HasColumnName("#Usuario");
        });

        modelBuilder.Entity<viw_Liquidacion_Transaccione>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viw_Liquidacion_Transacciones");

            entity.Property(e => e.datFechaHora).HasColumnType("datetime");
            entity.Property(e => e.strCliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strLetraFolio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strNomUsuario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPie1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strTipoTransaccion)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.strVehiculo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viw_NombreArchivo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viw_NombreArchivos");

            entity.Property(e => e.NomArchivo)
                .HasMaxLength(8000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viw_TanquesProducto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viw_TanquesProductos");

            entity.Property(e => e.strFolioPemex)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.strProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<viw_TransactionsAllRelation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viw_TransactionsAllRelations");

            entity.Property(e => e.Archivo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Materno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomCpdigoPemex)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.NomIsla)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomTPV)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomTipoVenta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Paterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoTransaccion)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.datFechahora).HasColumnType("datetime");
            entity.Property(e => e.strDescripcion)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.strIdentificador)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<vwCentralizacion_tblTransaccione>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCentralizacion_tblTransacciones");

            entity.Property(e => e.datFecha).HasMaxLength(10);
            entity.Property(e => e.datFechahora).HasColumnType("datetime");
            entity.Property(e => e.intID).ValueGeneratedOnAdd();
            entity.Property(e => e.strBandaMagnetica)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strCliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strFacturaCodigoCliente).HasMaxLength(50);
            entity.Property(e => e.strLetraFolio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strOdometro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strPie1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strPie4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strRendimiento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strTarjeta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.strTipoTransaccion)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.strTotalizadorFinal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.strVehiculo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
