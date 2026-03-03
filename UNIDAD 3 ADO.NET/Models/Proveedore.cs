using System;
using System.Collections.Generic;

namespace UNIDAD_3_ADO.NET.Models;

public partial class Proveedore
{
    public int ProveedorId { get; set; }

    public string Nombreproveedor { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();
}
