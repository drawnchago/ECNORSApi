using System;
using System.Collections.Generic;

namespace ECNORSAppData.Data.Models;

public partial class viwLiquidacion_Inventarios_Detalle
{
    public long ID { get; set; }

    public DateTime Fecha { get; set; }

    public long Secuencia { get; set; }

    public string? Movimiento { get; set; }

    public string? Referencia { get; set; }

    public string? Producto { get; set; }

    public string? Almacen { get; set; }

    public double? Cantidad { get; set; }

    public double? Existencia_Almacen { get; set; }

    public double? Existencia_Estacion { get; set; }

    public string? Usuario_Captura { get; set; }

    public long intID { get; set; }

    public DateTime datFecha { get; set; }

    public long intSecuencia { get; set; }

    public int? intMovimiento { get; set; }

    public string? strMovimiento { get; set; }

    public string? strDescripcion { get; set; }

    public int? intTipoMovimiento { get; set; }

    public string? strTipoMovimiento { get; set; }

    public string? strReferencia { get; set; }

    public int? intAlmacen { get; set; }

    public string? strAlmacen { get; set; }

    public int? intProducto { get; set; }

    public string? strProducto { get; set; }

    public double? dblCantidad { get; set; }

    public int? intSigno { get; set; }

    public string? strUsuario { get; set; }

    public string? strPC { get; set; }

    public string? strNombreUsuario { get; set; }
}
