using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Data
{
    public partial class CLUBPIPITAContext : DbContext
    {
        public CLUBPIPITAContext()
        {
        }

        public CLUBPIPITAContext(DbContextOptions<CLUBPIPITAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Arbitro> Arbitros { get; set; } = null!;
        public virtual DbSet<Dt> Dts { get; set; } = null!;
        public virtual DbSet<Equipo> Equipos { get; set; } = null!;
        public virtual DbSet<Estadistica> Estadisticas { get; set; } = null!;
        public virtual DbSet<Fasegrupo> Fasegrupos { get; set; } = null!;
        public virtual DbSet<Jugador> Jugadors { get; set; } = null!;
        public virtual DbSet<Partido> Partidos { get; set; } = null!;
        public virtual DbSet<Partidojugado> Partidojugados { get; set; } = null!;
        public virtual DbSet<Patrocinador> Patrocinadors { get; set; } = null!;
        public virtual DbSet<Persona> Personas { get; set; } = null!;
        public virtual DbSet<Rol> Rols { get; set; } = null!;
        public virtual DbSet<Torneo> Torneos { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arbitro>(entity =>
            {
                entity.ToTable("ARBITRO");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Funcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FUNCION");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Arbitro)
                    .HasForeignKey<Arbitro>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ARBITRO__ID__31EC6D26");
            });

            modelBuilder.Entity<Dt>(entity =>
            {
                entity.ToTable("DT");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Diplomados)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DIPLOMADOS");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Dt)
                    .HasForeignKey<Dt>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DT__ID__34C8D9D1");
            });

            modelBuilder.Entity<Equipo>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__EQUIPO__CC87E12733B8C5D0");

                entity.ToTable("EQUIPO");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<Estadistica>(entity =>
            {
                entity.HasKey(e => e.Idjugador)
                    .HasName("PK__ESTADIST__1D8BB1200BD17F79");

                entity.ToTable("ESTADISTICAS");

                entity.Property(e => e.Idjugador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDJUGADOR");

                entity.Property(e => e.Cantamarrillas).HasColumnName("CANTAMARRILLAS");

                entity.Property(e => e.Cantfaltas).HasColumnName("CANTFALTAS");

                entity.Property(e => e.Cantgoles).HasColumnName("CANTGOLES");

                entity.Property(e => e.Cantrojas).HasColumnName("CANTROJAS");

                entity.HasOne(d => d.IdjugadorNavigation)
                    .WithOne(p => p.Estadistica)
                    .HasForeignKey<Estadistica>(d => d.Idjugador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ESTADISTI__IDJUG__37A5467C");
            });

            modelBuilder.Entity<Fasegrupo>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__FASEGRUP__CC87E127319563FB");

                entity.ToTable("FASEGRUPOS");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Codfasegrupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODFASEGRUPO");

                entity.Property(e => e.Fechafinal)
                    .HasColumnType("date")
                    .HasColumnName("FECHAFINAL");

                entity.Property(e => e.Fechainicio)
                    .HasColumnType("date")
                    .HasColumnName("FECHAINICIO");

                entity.HasOne(d => d.CodfasegrupoNavigation)
                    .WithMany(p => p.Fasegrupos)
                    .HasForeignKey(d => d.Codfasegrupo)
                    .HasConstraintName("FK__FASEGRUPO__CODFA__3C69FB99");
            });

            modelBuilder.Entity<Jugador>(entity =>
            {
                entity.ToTable("JUGADOR");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Codequipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODEQUIPO");

                entity.Property(e => e.Numdorsal)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("NUMDORSAL");

                entity.HasOne(d => d.CodequipoNavigation)
                    .WithMany(p => p.Jugadors)
                    .HasForeignKey(d => d.Codequipo)
                    .HasConstraintName("FK__JUGADOR__CODEQUI__2F10007B");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Jugador)
                    .HasForeignKey<Jugador>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__JUGADOR__ID__2E1BDC42");
            });

            modelBuilder.Entity<Partido>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__PARTIDO__CC87E1278628E1D7");

                entity.ToTable("PARTIDO");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Codfasegrupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODFASEGRUPO");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("FECHA");

                entity.Property(e => e.Idarbrito)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDARBRITO");

                entity.HasOne(d => d.CodfasegrupoNavigation)
                    .WithMany(p => p.Partidos)
                    .HasForeignKey(d => d.Codfasegrupo)
                    .HasConstraintName("FK__PARTIDO__CODFASE__403A8C7D");

                entity.HasOne(d => d.IdarbritoNavigation)
                    .WithMany(p => p.Partidos)
                    .HasForeignKey(d => d.Idarbrito)
                    .HasConstraintName("FK__PARTIDO__IDARBRI__3F466844");
            });

            modelBuilder.Entity<Partidojugado>(entity =>
            {
                entity.HasKey(e => new { e.Codigopartido, e.Codigoequipo })
                    .HasName("PK__PARTIDOJ__5DCFF1D43C63F284");

                entity.ToTable("PARTIDOJUGADO");

                entity.Property(e => e.Codigopartido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODIGOPARTIDO");

                entity.Property(e => e.Codigoequipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODIGOEQUIPO");

                entity.Property(e => e.Ganador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GANADOR");

                entity.Property(e => e.Marcador)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MARCADOR");

                entity.HasOne(d => d.CodigoequipoNavigation)
                    .WithMany(p => p.Partidojugados)
                    .HasForeignKey(d => d.Codigoequipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PARTIDOJU__CODIG__440B1D61");

                entity.HasOne(d => d.CodigopartidoNavigation)
                    .WithMany(p => p.Partidojugados)
                    .HasForeignKey(d => d.Codigopartido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PARTIDOJU__CODIG__4316F928");
            });

            modelBuilder.Entity<Patrocinador>(entity =>
            {
                entity.ToTable("PATROCINADOR");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.HasMany(d => d.Codequipos)
                    .WithMany(p => p.Idpatrocinadors)
                    .UsingEntity<Dictionary<string, object>>(
                        "Patrocinadorequipo",
                        l => l.HasOne<Equipo>().WithMany().HasForeignKey("Codequipo").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__PATROCINA__CODEQ__49C3F6B7"),
                        r => r.HasOne<Patrocinador>().WithMany().HasForeignKey("Idpatrocinador").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__PATROCINA__IDPAT__48CFD27E"),
                        j =>
                        {
                            j.HasKey("Idpatrocinador", "Codequipo").HasName("PK__PATROCIN__7A40E1FF9F42C3FA");

                            j.ToTable("PATROCINADOREQUIPO");

                            j.IndexerProperty<string>("Idpatrocinador").HasMaxLength(50).IsUnicode(false).HasColumnName("IDPATROCINADOR");

                            j.IndexerProperty<string>("Codequipo").HasMaxLength(50).IsUnicode(false).HasColumnName("CODEQUIPO");
                        });
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.ToTable("PERSONA");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APELLIDO");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONO");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO");

                entity.HasOne(d => d.UsuarioNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.Usuario)
                    .HasConstraintName("FK__PERSONA__USUARIO__29572725");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__ROL__CC87E127363B43E3");

                entity.ToTable("ROL");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Nombrerol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBREROL");
            });

            modelBuilder.Entity<Torneo>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__TORNEO__CC87E127601F41D1");

                entity.ToTable("TORNEO");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Fechafinal)
                    .HasColumnType("date")
                    .HasColumnName("FECHAFINAL");

                entity.Property(e => e.Fechainicio)
                    .HasColumnType("date")
                    .HasColumnName("FECHAINICIO");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Correo)
                    .HasName("PK__USUARIO__264F33C9F3364370");

                entity.ToTable("USUARIO");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CORREO");

                entity.Property(e => e.Codrol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CODROL");

                entity.Property(e => e.Contarsena)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONTARSENA");

                entity.HasOne(d => d.CodrolNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.Codrol)
                    .HasConstraintName("FK__USUARIO__CODROL__267ABA7A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
