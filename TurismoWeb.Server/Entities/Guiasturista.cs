using System;
using System.Collections.Generic;

namespace TurismoWeb.Server.Entities;

public partial class Guiasturista
{
    public int Id { get; set; }

    public string? Dni { get; set; }

    public string? Nombre { get; set; }

    public string? Apellidos { get; set; }

    public string? Correo { get; set; }

    public string? Telefono { get; set; }

    public int? UsuariosId { get; set; }

    public virtual ICollection<ApreciacionGuium> ApreciacionGuia { get; set; } = new List<ApreciacionGuium>();

    public virtual ICollection<Paquete> Paquetes { get; set; } = new List<Paquete>();

    public virtual ICollection<Servicio> Servicios { get; set; } = new List<Servicio>();

    public virtual ICollection<Sitiosturistico> Sitiosturisticos { get; set; } = new List<Sitiosturistico>();

    
}
