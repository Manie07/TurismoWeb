using System;
using System.Collections.Generic;
using TurismoWeb.Server.Entities;

namespace TurismoWeb.Server.Data;

public partial class Turista
{
    public int Id { get; set; }

    public string? Dni { get; set; }

    public string? Nombre { get; set; }

    public string? Apellidos { get; set; }

    public string? Correo { get; set; }

    public string? Telefono { get; set; }

    public string? Pais { get; set; }

    public string? DireccionHospedaje { get; set; }

    public int? UsuariosId { get; set; }

    public virtual ICollection<Acompanante> Acompanantes { get; set; } = new List<Acompanante>();

    public virtual ICollection<ApreciacionEstum> ApreciacionEsta { get; set; } = new List<ApreciacionEstum>();

    public virtual ICollection<ApreciacionGuium> ApreciacionGuia { get; set; } = new List<ApreciacionGuium>();

    public virtual ICollection<ApreciacionSitio> ApreciacionSitios { get; set; } = new List<ApreciacionSitio>();

    public virtual ICollection<Reservacione> Reservaciones { get; set; } = new List<Reservacione>();

    public virtual Usuario? Usuarios { get; set; }
}
