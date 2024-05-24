using System;
using System.Collections.Generic;

namespace TurismoWeb.Server.Entities;

public partial class Sitiosturistico
{
    public int Id { get; set; }

    public string? Direccion { get; set; }

    public string? Nombre { get; set; }

    public string? Tipo { get; set; }

    public string? Descripcion { get; set; }

    public TimeOnly? HoraApertura { get; set; }

    public TimeOnly? HoraCierre { get; set; }

    public int? GuiasturistasId { get; set; }

    public virtual ICollection<ApreciacionSitio> ApreciacionSitios { get; set; } = new List<ApreciacionSitio>();

    public virtual Guiasturista? Guiasturistas { get; set; }
}
