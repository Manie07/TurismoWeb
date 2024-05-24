using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TurismoWeb.Server.Entities;

namespace TurismoWeb.Server.Data;

public partial class TurismowebContext : DbContext
{
   private readonly IConfiguration configuration;

    public TurismowebContext(DbContextOptions<TurismowebContext> options, IConfiguration configuration)
        : base(options)
    {
        this.configuration = configuration;
    }

    public virtual DbSet<Acompanante> Acompanantes { get; set; }

    public virtual DbSet<ApreciacionEstum> ApreciacionEsta { get; set; }

    public virtual DbSet<ApreciacionGuium> ApreciacionGuia { get; set; }

    public virtual DbSet<ApreciacionSitio> ApreciacionSitios { get; set; }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<ComprasRealizada> ComprasRealizadas { get; set; }

    public virtual DbSet<CrearSolicitud> CrearSolicituds { get; set; }

    public virtual DbSet<Establecimiento> Establecimientos { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<GuiaSitio> GuiaSitios { get; set; }

    public virtual DbSet<Guiasturista> Guiasturistas { get; set; }

    public virtual DbSet<PCompra> PCompras { get; set; }

    public virtual DbSet<PEstablecimiento> PEstablecimientos { get; set; }

    public virtual DbSet<PServicio> PServicios { get; set; }

    public virtual DbSet<PSitiosturistico> PSitiosturisticos { get; set; }

    public virtual DbSet<Paquete> Paquetes { get; set; }

    public virtual DbSet<RecibirSolicitud> RecibirSolicituds { get; set; }

    public virtual DbSet<Reservacione> Reservaciones { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<Sitiosturistico> Sitiosturisticos { get; set; }

    public virtual DbSet<Solicitude> Solicitudes { get; set; }

    public virtual DbSet<Turista> Turistas { get; set; }
   
    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Usuariosprueba> Usuariospruebas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Acompanante>(entity =>
        {
            entity.HasKey(e => e.Dni).HasName("PK__acompana__D87608A6D23BD7D4");

            entity.ToTable("acompanantes");

            entity.Property(e => e.Dni)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("dni");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.TuristasId).HasColumnName("turistas_id");

            entity.HasOne(d => d.Turistas).WithMany(p => p.Acompanantes)
                .HasForeignKey(d => d.TuristasId)
                .HasConstraintName("FK__acompanan__turis__49C3F6B7");
        });

        modelBuilder.Entity<ApreciacionEstum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__apreciac__3213E83F77D3A6F7");

            entity.ToTable("apreciacion_esta");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Calificacion).HasColumnName("calificacion");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.EstablecimientosId).HasColumnName("establecimientos_id");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.TuristasId).HasColumnName("turistas_id");

            entity.HasOne(d => d.Establecimientos).WithMany(p => p.ApreciacionEsta)
                .HasForeignKey(d => d.EstablecimientosId)
                .HasConstraintName("FK__apreciaci__estab__5165187F");

            entity.HasOne(d => d.Turistas).WithMany(p => p.ApreciacionEsta)
                .HasForeignKey(d => d.TuristasId)
                .HasConstraintName("FK__apreciaci__turis__5070F446");
        });

        modelBuilder.Entity<ApreciacionGuium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__apreciac__3213E83FB070643A");

            entity.ToTable("apreciacion_guia");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Calificacion).HasColumnName("calificacion");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.GuiasturistasId).HasColumnName("guiasturistas_id");
            entity.Property(e => e.TuristasId).HasColumnName("turistas_id");

            entity.HasOne(d => d.Guiasturistas).WithMany(p => p.ApreciacionGuia)
                .HasForeignKey(d => d.GuiasturistasId)
                .HasConstraintName("FK__apreciaci__guias__5535A963");

            entity.HasOne(d => d.Turistas).WithMany(p => p.ApreciacionGuia)
                .HasForeignKey(d => d.TuristasId)
                .HasConstraintName("FK__apreciaci__turis__5441852A");
        });

        modelBuilder.Entity<ApreciacionSitio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__apreciac__3213E83F9F0C2FA4");

            entity.ToTable("apreciacion_sitio");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Calificacion).HasColumnName("calificacion");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.SitiosturisticosId).HasColumnName("sitiosturisticos_id");
            entity.Property(e => e.TuristasId).HasColumnName("turistas_id");

            entity.HasOne(d => d.Sitiosturisticos).WithMany(p => p.ApreciacionSitios)
                .HasForeignKey(d => d.SitiosturisticosId)
                .HasConstraintName("FK__apreciaci__sitio__5CD6CB2B");

            entity.HasOne(d => d.Turistas).WithMany(p => p.ApreciacionSitios)
                .HasForeignKey(d => d.TuristasId)
                .HasConstraintName("FK__apreciaci__turis__5BE2A6F2");
        });

        modelBuilder.Entity<Compra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__compras__3213E83F72A2CCED");

            entity.ToTable("compras");

            entity.HasIndex(e => e.Codigo, "UQ__compras__40F9A206351DF72C").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
        });

        modelBuilder.Entity<ComprasRealizada>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("compras_realizadas");

            entity.Property(e => e.ComprasId).HasColumnName("compras_id");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Hora).HasColumnName("hora");
            entity.Property(e => e.TuristaId).HasColumnName("turista_id");

            entity.HasOne(d => d.Compras).WithMany()
                .HasForeignKey(d => d.ComprasId)
                .HasConstraintName("FK__compras_r__compr__628FA481");

            entity.HasOne(d => d.Turista).WithMany()
                .HasForeignKey(d => d.TuristaId)
                .HasConstraintName("FK__compras_r__turis__619B8048");
        });

        modelBuilder.Entity<CrearSolicitud>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("crear_solicitud");

            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Hora)
                .HasColumnType("datetime")
                .HasColumnName("hora");
            entity.Property(e => e.SolicitudesId).HasColumnName("solicitudes_id");
            entity.Property(e => e.TuristasId).HasColumnName("turistas_id");

            entity.HasOne(d => d.Solicitudes).WithMany()
                .HasForeignKey(d => d.SolicitudesId)
                .HasConstraintName("FK__crear_sol__solic__45F365D3");

            entity.HasOne(d => d.Turistas).WithMany()
                .HasForeignKey(d => d.TuristasId)
                .HasConstraintName("FK__crear_sol__turis__46E78A0C");
        });

        modelBuilder.Entity<Establecimiento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__establec__3213E83FBC014020");

            entity.ToTable("establecimientos");

            entity.HasIndex(e => e.Nit, "UQ__establec__DF97D0E4A6FB0B7F").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Disponibilidad)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("disponibilidad");
            entity.Property(e => e.Nit)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nit");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Tipo)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ubicacion");
            entity.Property(e => e.UsuariosId).HasColumnName("usuarios_id");


        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__facturas__3213E83FBA97D176");

            entity.ToTable("facturas");

            entity.HasIndex(e => e.Codigo, "UQ__facturas__40F9A2061DB1AEE4").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.ComprasId).HasColumnName("compras_id");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.TotalCompras).HasColumnName("totalCompras");

            entity.HasOne(d => d.Compras).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.ComprasId)
                .HasConstraintName("FK__facturas__compra__66603565");
        });

        modelBuilder.Entity<GuiaSitio>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("guia_sitio");

            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.GuiasturistasId).HasColumnName("guiasturistas_id");
            entity.Property(e => e.SitiosturisticosId).HasColumnName("sitiosturisticos_id");

            entity.HasOne(d => d.Guiasturistas).WithMany()
                .HasForeignKey(d => d.GuiasturistasId)
                .HasConstraintName("FK__guia_siti__guias__68487DD7");

            entity.HasOne(d => d.Sitiosturisticos).WithMany()
                .HasForeignKey(d => d.SitiosturisticosId)
                .HasConstraintName("FK__guia_siti__sitio__693CA210");
        });

        modelBuilder.Entity<Guiasturista>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__guiastur__3213E83FB9ADCC97");

            entity.ToTable("guiasturistas");

            entity.HasIndex(e => e.Dni, "UQ__guiastur__D87608A792B120C3").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.Correo)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.Dni)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("dni");
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.UsuariosId).HasColumnName("usuarios_id");


            modelBuilder.Entity<PCompra>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("p_compras");

                entity.Property(e => e.ComprasId).HasColumnName("compras_id");
                entity.Property(e => e.Fecha).HasColumnName("fecha");
                entity.Property(e => e.Hora).HasColumnName("hora");
                entity.Property(e => e.PaquetesId).HasColumnName("paquetes_id");

                entity.HasOne(d => d.Compras).WithMany()
                    .HasForeignKey(d => d.ComprasId)
                    .HasConstraintName("FK__p_compras__compr__6FE99F9F");

                entity.HasOne(d => d.Paquetes).WithMany()
                    .HasForeignKey(d => d.PaquetesId)
                    .HasConstraintName("FK__p_compras__paque__6EF57B66");
            });

            modelBuilder.Entity<PEstablecimiento>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("p_establecimiento");

                entity.Property(e => e.Disponibilidad).HasColumnName("disponibilidad");
                entity.Property(e => e.EstablecimientosId).HasColumnName("establecimientos_id");
                entity.Property(e => e.Fecha).HasColumnName("fecha");
                entity.Property(e => e.Hora).HasColumnName("hora");
                entity.Property(e => e.PaquetesId).HasColumnName("paquetes_id");

                entity.HasOne(d => d.Establecimientos).WithMany()
                    .HasForeignKey(d => d.EstablecimientosId)
                    .HasConstraintName("FK__p_estable__estab__72C60C4A");

                entity.HasOne(d => d.Paquetes).WithMany()
                    .HasForeignKey(d => d.PaquetesId)
                    .HasConstraintName("FK__p_estable__paque__71D1E811");
            });

            modelBuilder.Entity<PServicio>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("p_servicios");

                entity.Property(e => e.PaquetesId).HasColumnName("paquetes_id");
                entity.Property(e => e.PrecioAdicional).HasColumnName("precio_adicional");
                entity.Property(e => e.ServiciosId).HasColumnName("servicios_id");

                entity.HasOne(d => d.Paquetes).WithMany()
                    .HasForeignKey(d => d.PaquetesId)
                    .HasConstraintName("FK__p_servici__paque__778AC167");

                entity.HasOne(d => d.Servicios).WithMany()
                    .HasForeignKey(d => d.ServiciosId)
                    .HasConstraintName("FK__p_servici__servi__787EE5A0");
            });

            modelBuilder.Entity<PSitiosturistico>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("p_sitiosturisticos");

                entity.Property(e => e.Disponibilidad).HasColumnName("disponibilidad");
                entity.Property(e => e.PaquetesId).HasColumnName("paquetes_id");
                entity.Property(e => e.SitiosturisticosId).HasColumnName("sitiosturisticos_id");

                entity.HasOne(d => d.Paquetes).WithMany()
                    .HasForeignKey(d => d.PaquetesId)
                    .HasConstraintName("FK__p_sitiost__paque__7A672E12");

                entity.HasOne(d => d.Sitiosturisticos).WithMany()
                    .HasForeignKey(d => d.SitiosturisticosId)
                    .HasConstraintName("FK__p_sitiost__sitio__7B5B524B");
            });

            modelBuilder.Entity<Paquete>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__paquetes__3213E83FDCBDEB5B");

                entity.ToTable("paquetes");

                entity.HasIndex(e => e.Codigo, "UQ__paquetes__40F9A206CBA2892E").IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Codigo).HasColumnName("codigo");
                entity.Property(e => e.GuiasturistasId).HasColumnName("guiasturistas_id");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
                entity.Property(e => e.Precio).HasColumnName("precio");
                entity.Property(e => e.Tipo)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("tipo");

                entity.HasOne(d => d.Guiasturistas).WithMany(p => p.Paquetes)
                    .HasForeignKey(d => d.GuiasturistasId)
                    .HasConstraintName("FK__paquetes__guiast__6D0D32F4");
            });

            modelBuilder.Entity<RecibirSolicitud>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("recibir_solicitud");

                entity.Property(e => e.Fecha).HasColumnName("fecha");
                entity.Property(e => e.GuiasturistasId).HasColumnName("guiasturistas_id");
                entity.Property(e => e.Hora)
                    .HasColumnType("datetime")
                    .HasColumnName("hora");
                entity.Property(e => e.SolicitudesId).HasColumnName("solicitudes_id");

                entity.HasOne(d => d.Guiasturistas).WithMany()
                    .HasForeignKey(d => d.GuiasturistasId)
                    .HasConstraintName("FK__recibir_s__guias__3F466844");

                entity.HasOne(d => d.Solicitudes).WithMany()
                    .HasForeignKey(d => d.SolicitudesId)
                    .HasConstraintName("FK__recibir_s__solic__403A8C7D");
            });

            modelBuilder.Entity<Reservacione>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__reservac__3213E83FE863DFF6");

                entity.ToTable("reservaciones");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Confirmacion).HasColumnName("confirmacion");
                entity.Property(e => e.EstablecimientosId).HasColumnName("establecimientos_id");
                entity.Property(e => e.Fecha).HasColumnName("fecha");
                entity.Property(e => e.Hora).HasColumnName("hora");
                entity.Property(e => e.TuristaId).HasColumnName("turista_id");

                entity.HasOne(d => d.Establecimientos).WithMany(p => p.Reservaciones)
                    .HasForeignKey(d => d.EstablecimientosId)
                    .HasConstraintName("FK__reservaci__estab__7F2BE32F");

                entity.HasOne(d => d.Turista).WithMany(p => p.Reservaciones)
                    .HasForeignKey(d => d.TuristaId)
                    .HasConstraintName("FK__reservaci__turis__7E37BEF6");
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__servicio__3213E83F574EF0B2");

                entity.ToTable("servicios");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Descripcion)
                    .HasColumnType("text")
                    .HasColumnName("descripcion");
                entity.Property(e => e.GuiasturistasId).HasColumnName("guiasturistas_id");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo");

                entity.HasOne(d => d.Guiasturistas).WithMany(p => p.Servicios)
                    .HasForeignKey(d => d.GuiasturistasId)
                    .HasConstraintName("FK__servicios__guias__75A278F5");
            });

            modelBuilder.Entity<Sitiosturistico>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__sitiostu__3213E83FC48C5F91");

                entity.ToTable("sitiosturisticos");

                entity.HasIndex(e => e.Nombre, "UQ__sitiostu__72AFBCC67DE4D3EF").IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Descripcion)
                    .HasColumnType("text")
                    .HasColumnName("descripcion");
                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");
                entity.Property(e => e.GuiasturistasId).HasColumnName("guiasturistas_id");
                entity.Property(e => e.HoraApertura).HasColumnName("hora_apertura");
                entity.Property(e => e.HoraCierre).HasColumnName("hora_cierre");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
                entity.Property(e => e.Tipo)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("tipo");

                entity.HasOne(d => d.Guiasturistas).WithMany(p => p.Sitiosturisticos)
                    .HasForeignKey(d => d.GuiasturistasId)
                    .HasConstraintName("FK__sitiostur__guias__59063A47");
            });

            modelBuilder.Entity<Solicitude>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__solicitu__3213E83F46EADBFC");

                entity.ToTable("solicitudes");

                entity.HasIndex(e => e.Codigo, "UQ__solicitu__40F9A20601271793").IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Codigo).HasColumnName("codigo");
                entity.Property(e => e.Descripcion)
                    .HasColumnType("text")
                    .HasColumnName("descripcion");
                entity.Property(e => e.Precio).HasColumnName("precio");
            });

            modelBuilder.Entity<Turista>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__turistas__3213E83F1EC600E8");

                entity.ToTable("turistas");

                entity.HasIndex(e => e.Dni, "UQ__turistas__D87608A754DBE061").IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Apellidos)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("apellidos");
                entity.Property(e => e.Correo)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("correo");
                entity.Property(e => e.DireccionHospedaje)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion_hospedaje");
                entity.Property(e => e.Dni)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dni");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
                entity.Property(e => e.Pais)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("pais");
                entity.Property(e => e.Telefono)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
                entity.Property(e => e.UsuariosId).HasColumnName("usuarios_id");

                entity.HasOne(d => d.Usuarios).WithMany(p => p.Turista)
                    .HasForeignKey(d => d.UsuariosId)
                    .HasConstraintName("FK__turistas__usuari__440B1D61");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__usuarios__3213E83F746600AB");

                entity.ToTable("usuarios");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Contrasena)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("contrasena");
                entity.Property(e => e.Tipo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("tipo");
                entity.Property(e => e.Usuario1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<Usuariosprueba>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_usuarios");

                entity.ToTable("usuariosprueba");
            });

            OnModelCreatingPartial(modelBuilder);
        });
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
