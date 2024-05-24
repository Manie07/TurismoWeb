using System;
using System.Collections.Generic;

namespace TurismoWeb.Server.Entities;

public partial class PSitiosturistico
{
    public byte? Disponibilidad { get; set; }

    public int? PaquetesId { get; set; }

    public int? SitiosturisticosId { get; set; }

    public virtual Paquete? Paquetes { get; set; }

    public virtual Sitiosturistico? Sitiosturisticos { get; set; }
}
