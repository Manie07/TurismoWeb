using System;
using System.Collections.Generic;

namespace TurismoWeb.Server.Entities;

public partial class PCompra
{
    public TimeOnly? Hora { get; set; }

    public DateOnly? Fecha { get; set; }

    public int? PaquetesId { get; set; }

    public int? ComprasId { get; set; }

    public virtual Compra? Compras { get; set; }

    public virtual Paquete? Paquetes { get; set; }
}
