using System;
using System.Collections.Generic;

namespace TurismoWeb.Server.Data;

public partial class Usuariosprueba
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string PrimerNombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Lugar { get; set; } = null!;
}
