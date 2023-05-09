using System;
using System.Collections.Generic;

namespace Tienda.Models;

public partial class Producto
{
    //campos
    public int Id { get; set; }

    public string Producto1 { get; set; } = null!;

    public int Cantidad { get; set; }
}
