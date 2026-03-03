using System;
using System.Collections.Generic;

namespace UNIDAD_3_ADO.NET.Models;

public partial class Factura
{
    public int FacturaId { get; set; }

    public int? ClienteId { get; set; }

    public DateOnly Fechafactura { get; set; }

    public decimal Total { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual ICollection<Detallesfactura> Detallesfacturas { get; set; } = new List<Detallesfactura>();
}
