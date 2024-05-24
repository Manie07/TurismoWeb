using System;
using System.Collections.Generic;

namespace TurismoWeb.Server.Entities;

public partial class PEstablecimiento
{
    public byte? Disponibilidad { get; set; }

    public TimeOnly? Hora { get; set; }

    public DateOnly? Fecha { get; set; }

    public int? PaquetesId { get; set; }

    public int? EstablecimientosId { get; set; }

    public virtual Establecimiento? Establecimientos { get; set; }

    public virtual Paquete? Paquetes { get; set; }
}
