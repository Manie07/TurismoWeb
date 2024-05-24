using System;
using System.Collections.Generic;

namespace TurismoWeb.Server.Entities;

public partial class Servicio
{
    public int Id { get; set; }

    public string? Tipo { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int? GuiasturistasId { get; set; }

    public virtual Guiasturista? Guiasturistas { get; set; }
}
