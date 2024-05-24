using System;
using System.Collections.Generic;

namespace TurismoWeb.Server.Entities;

public partial class Solicitude
{
    public int Id { get; set; }

    public int? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public double? Precio { get; set; }
}
