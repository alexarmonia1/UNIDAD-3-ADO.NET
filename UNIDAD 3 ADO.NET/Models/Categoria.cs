using System;
using System.Collections.Generic;

namespace UNIDAD_3_ADO.NET.Models;

public partial class Categoria
{
    public int CategoriaId { get; set; }

    public string Nombrecategoria { get; set; } = null!;

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
