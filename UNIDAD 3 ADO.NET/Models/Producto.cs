using System;
using System.Collections.Generic;

namespace UNIDAD_3_ADO.NET.Models;

public partial class Producto
{
    public int ProductoId { get; set; }

    public string Nombreproducto { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal Precio { get; set; }

    public int Stock { get; set; }

    public int? CategoriaId { get; set; }

    public virtual Categoria? Categoria { get; set; }

    public virtual ICollection<Detallescompra> Detallescompras { get; set; } = new List<Detallescompra>();

    public virtual ICollection<Detallesfactura> Detallesfacturas { get; set; } = new List<Detallesfactura>();
}
