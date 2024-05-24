using System;
using System.Collections.Generic;
using TurismoWeb.Server.Data;

namespace TurismoWeb.Server.Entities;

public partial class Reservacione
{
    public int Id { get; set; }

    public byte? Confirmacion { get; set; }

    public TimeOnly? Hora { get; set; }

    public DateOnly? Fecha { get; set; }

    public int? TuristaId { get; set; }

    public int? EstablecimientosId { get; set; }

    public virtual Establecimiento? Establecimientos { get; set; }

    public virtual Turista? Turista { get; set; }
}
