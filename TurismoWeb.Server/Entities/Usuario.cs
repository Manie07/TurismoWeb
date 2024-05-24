using System;
using System.Collections.Generic;
using TurismoWeb.Server.Entities;

namespace TurismoWeb.Server.Data;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Usuario1 { get; set; }

    public string? Contrasena { get; set; }

    public string? Tipo { get; set; }

    public virtual ICollection<Establecimiento> Establecimientos { get; set; } = new List<Establecimiento>();

    public virtual ICollection<Guiasturista> Guiasturista { get; set; } = new List<Guiasturista>();

    public virtual ICollection<Turista> Turista { get; set; } = new List<Turista>();
}
