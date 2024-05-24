using System;
using System.Collections.Generic;

namespace TurismoWeb.Server.Entities;

public partial class Compra
{
    public int Id { get; set; }

    public int? Codigo { get; set; }

    public DateTime? Fecha { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}
