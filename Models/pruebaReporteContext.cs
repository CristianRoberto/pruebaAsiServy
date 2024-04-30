using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace pruebaasiservy.Models
{
    public partial class pruebaReporteContext : DbContext
    {
        public pruebaReporteContext()
        {
        }

        public pruebaReporteContext(DbContextOptions<pruebaReporteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cabecera> Cabeceras { get; set; } = null!;
        public virtual DbSet<Empaque> Empaques { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
////#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
////                optionsBuilder.UseSqlServer("Server=J01ERP81B8R\\MVC;Database=pruebaReporte;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cabecera>(entity =>
            {
                entity.ToTable("Cabecera");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Linea1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Linea_1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Linea2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Linea_2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Linea3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Linea_3")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Linea4)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Linea_4")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Linea5)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Linea_5")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Linea6)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Linea_6")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(16, 4)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Empaque>(entity =>
            {
                entity.ToTable("Empaque");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Faltas)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Permiso)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Pmedico)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PMedico")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(16, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Totalp)
                    .HasColumnType("decimal(16, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Vacaciones)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
