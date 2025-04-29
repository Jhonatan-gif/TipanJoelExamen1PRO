using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TipanExamen.Models;

    public class TipanData : DbContext
    {
        public TipanData (DbContextOptions<TipanData> options)
            : base(options)
        {
        }

        public DbSet<TipanExamen.Models.Cliente> Cliente { get; set; } = default!;

public DbSet<TipanExamen.Models.PlanRecompensas> PlanRecompensas { get; set; } = default!;
    }
