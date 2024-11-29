using System;
using System.Collections.Generic;
using AQAPIAuto.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AQAPIAuto.Data;

public partial class AQAutosContext : DbContext
{
    public AQAutosContext()
    {
    }

    public AQAutosContext(DbContextOptions<AQAutosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aqauto> Aqautos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AQAutos");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aqauto>(entity =>
        {
            entity.ToTable("AQAuto");

            entity.Property(e => e.AqautoId).HasColumnName("AQAutoID");
            entity.Property(e => e.Aqanio).HasColumnName("AQAnio");
            entity.Property(e => e.Aqcombustible)
                .HasMaxLength(10)
                .HasColumnName("AQCombustible");
            entity.Property(e => e.AqfechaIngreso).HasColumnName("AQFechaIngreso");
            entity.Property(e => e.Aqmarca)
                .HasMaxLength(50)
                .HasColumnName("AQMarca");
            entity.Property(e => e.Aqprecio)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AQPrecio");
            entity.Property(e => e.Aqusado).HasColumnName("AQUsado");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
