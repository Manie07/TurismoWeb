using System;
using System.Collections.Generic;

namespace TurismoWeb.Server.Entities;

public partial class PServicio
{
    public double? PrecioAdicional { get; set; }

    public int? PaquetesId { get; set; }

    public int? ServiciosId { get; set; }

    public virtual Paquete? Paquetes { get; set; }

    public virtual Servicio? Servicios { get; set; }
}
