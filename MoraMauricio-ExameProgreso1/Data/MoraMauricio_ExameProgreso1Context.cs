using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoraMauricio_ExameProgreso1.Models;

namespace MoraMauricio_ExameProgreso1.Data
{
    public class MoraMauricio_ExameProgreso1Context : DbContext
    {
        public MoraMauricio_ExameProgreso1Context (DbContextOptions<MoraMauricio_ExameProgreso1Context> options)
            : base(options)
        {
        }

        public DbSet<MoraMauricio_ExameProgreso1.Models.Celular> Celular { get; set; } = default!;
        public DbSet<MoraMauricio_ExameProgreso1.Models.MMora> MMora { get; set; } = default!;
    }
}
