using System;
using System.Collections.Generic;

namespace TurismoWeb.Server.Entities;

public partial class Establecimiento
{
    public int Id { get; set; }

    public string? Nit { get; set; }

    public string? Nombre { get; set; }

    public string? Ubicacion { get; set; }

    public string? Tipo { get; set; }

    public string? Disponibilidad { get; set; }

    public int? UsuariosId { get; set; }

    public virtual ICollection<ApreciacionEstum> ApreciacionEsta { get; set; } = new List<ApreciacionEstum>();

    public virtual ICollection<Reservacione> Reservaciones { get; set; } = new List<Reservacione>();

   
}
