using System;
using System.Collections.Generic;

namespace UNIDAD_3_ADO.NET.Models;

public partial class Compra
{
    public int CompraId { get; set; }

    public int ProveedorId { get; set; }

    public DateOnly Fechacompra { get; set; }

    public decimal Total { get; set; }

    public virtual ICollection<Detallescompra> Detallescompras { get; set; } = new List<Detallescompra>();

    public virtual Proveedore Proveedor { get; set; } = null!;
}
