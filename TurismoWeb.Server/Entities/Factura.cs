using System;
using System.Collections.Generic;

namespace TurismoWeb.Server.Entities;

public partial class Factura
{
    public int Id { get; set; }

    public int? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? Fecha { get; set; }

    public double? TotalCompras { get; set; }

    public int? ComprasId { get; set; }

    public virtual Compra? Compras { get; set; }
}
