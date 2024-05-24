using System;
using System.Collections.Generic;

namespace TurismoWeb.Server.Entities;

public partial class GuiaSitio
{
    public DateTime? Fecha { get; set; }

    public int? GuiasturistasId { get; set; }

    public int? SitiosturisticosId { get; set; }

    public virtual Guiasturista? Guiasturistas { get; set; }

    public virtual Sitiosturistico? Sitiosturisticos { get; set; }
}
