using System;
using System.Collections.Generic;

namespace UNIDAD_3_ADO.NET.Models;

public partial class Cliente
{
    public int ClienteId { get; set; }

    public string Nombrecompleto { get; set; } = null!;

    public string? CorreoElectronico { get; set; }

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}
