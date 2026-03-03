using System;
using System.Collections.Generic;

namespace UNIDAD_3_ADO.NET.Models;

public partial class Detallesfactura
{
    public int DetalleId { get; set; }

    public int FacturaId { get; set; }

    public int ProductoId { get; set; }

    public int Cantidad { get; set; }

    public decimal Precio { get; set; }

    public decimal Impuesto { get; set; }

    public decimal Subtotal { get; set; }

    public virtual Factura Factura { get; set; } = null!;

    public virtual Producto Producto { get; set; } = null!;
}
