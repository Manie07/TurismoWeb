using System;
using System.Collections.Generic;
using TurismoWeb.Server.Data;

namespace TurismoWeb.Server.Entities;

public partial class Acompanante
{
    public string Dni { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Apellidos { get; set; }

    public int? TuristasId { get; set; }

    public virtual Turista? Turistas { get; set; }
}
