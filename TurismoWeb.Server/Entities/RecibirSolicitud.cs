using System;
using System.Collections.Generic;

namespace TurismoWeb.Server.Entities;

public partial class RecibirSolicitud
{
    public DateTime? Hora { get; set; }

    public DateOnly? Fecha { get; set; }

    public int? GuiasturistasId { get; set; }

    public int? SolicitudesId { get; set; }

    public virtual Guiasturista? Guiasturistas { get; set; }

    public virtual Solicitude? Solicitudes { get; set; }
}
