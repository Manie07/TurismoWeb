using System;
using System.Collections.Generic;
using TurismoWeb.Server.Data;

namespace TurismoWeb.Server.Entities;

public partial class ApreciacionEstum
{
    public int Id { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Descripcion { get; set; }

    public int? TuristasId { get; set; }

    public int? EstablecimientosId { get; set; }

    public double? Calificacion { get; set; }

    public virtual Establecimiento? Establecimientos { get; set; }

    public virtual Turista? Turistas { get; set; }
}
