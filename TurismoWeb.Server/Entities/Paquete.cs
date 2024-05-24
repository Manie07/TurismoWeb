using System;
using System.Collections.Generic;

namespace TurismoWeb.Server.Entities;

public partial class Paquete
{
    public int Id { get; set; }

    public int? Codigo { get; set; }

    public string? Nombre { get; set; }

    public string? Tipo { get; set; }

    public double? Precio { get; set; }

    public int? GuiasturistasId { get; set; }

    public virtual Guiasturista? Guiasturistas { get; set; }
}
