using System;
using System.Collections.Generic;
using TurismoWeb.Server.Data;

namespace TurismoWeb.Server.Entities;

public partial class ComprasRealizada
{
    public DateOnly? Fecha { get; set; }

    public TimeOnly? Hora { get; set; }

    public int? TuristaId { get; set; }

    public int? ComprasId { get; set; }

    public virtual Compra? Compras { get; set; }

    public virtual Turista? Turista { get; set; }
}
