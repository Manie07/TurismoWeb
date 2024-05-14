using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TurismoWeb.Server.Entities;

namespace TurismoWeb.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext( DbContextOptions<DataContext> options ) : base(options)
            {



            }

        public DbSet<Usuario> usuariosprueba { get; set; }
    }
}
