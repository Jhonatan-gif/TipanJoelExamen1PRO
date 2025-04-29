using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TipanExamen.Models;

public class TipanData : DbContext
{
    public TipanData(DbContextOptions<TipanData> options)
        : base(options)
    {
    }

    public DbSet<Cliente> Cliente { get; set; } = default!;
    public DbSet<PlanRecompensas> PlanRecompensas { get; set; } = default!;
    public DbSet<Reserva> Reserva { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuración para evitar la advertencia del decimal truncado
        modelBuilder.Entity<Reserva>()
            .Property(r => r.ValorPagar)
            .HasPrecision(18, 2);
    }
}
