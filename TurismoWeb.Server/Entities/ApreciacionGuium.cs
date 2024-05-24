using System;
using System.Collections.Generic;
using TurismoWeb.Server.Data;

namespace TurismoWeb.Server.Entities;

public partial class ApreciacionGuium
{
    public int Id { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Descripcion { get; set; }

    public int? TuristasId { get; set; }

    public int? GuiasturistasId { get; set; }

    public double? Calificacion { get; set; }

    public virtual Guiasturista? Guiasturistas { get; set; }

    public virtual Turista? Turistas { get; set; }
}
