using System;
using System.Collections.Generic;

namespace UNIDAD_3_ADO.NET.Models;

public partial class Detallescompra
{
    public int DetallecompraId { get; set; }

    public int CompraId { get; set; }

    public int ProductoId { get; set; }

    public int Cantidad { get; set; }

    public decimal Costounitario { get; set; }

    public decimal Impuesto { get; set; }

    public decimal Subtotal { get; set; }

    public virtual Compra Compra { get; set; } = null!;

    public virtual Producto Producto { get; set; } = null!;
}
