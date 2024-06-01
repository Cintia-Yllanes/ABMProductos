using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ABMProductos.Models;

public partial class Producto
{
    public int Idproducto { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Categoria { get; set; }

    [DataType(DataType.Date)]
    public DateTime? FechaIngreso { get; set; }

    public decimal? Precio { get; set; }

    public int? Stock { get; set; }

    public string? Imagen { get; set; }
}
