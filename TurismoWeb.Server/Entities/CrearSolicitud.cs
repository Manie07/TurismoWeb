using System;
using System.Collections.Generic;
using TurismoWeb.Server.Data;

namespace TurismoWeb.Server.Entities;

public partial class CrearSolicitud
{
    public DateTime? Hora { get; set; }

    public DateOnly? Fecha { get; set; }

    public int? SolicitudesId { get; set; }

    public int? TuristasId { get; set; }

    public virtual Solicitude? Solicitudes { get; set; }

    public virtual Turista? Turistas { get; set; }
}
