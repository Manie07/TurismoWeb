namespace TurismoWeb.Server.Entities
{
    public class Usuario
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public string PrimerNombre { get; set; } = string.Empty;

        public string Apellido { get; set;} = string.Empty;

        public string Lugar { get; set; } = string.Empty;
    }
}
