using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Estacionamento.Models;

namespace Estacionamento.Models
{
    public class EstacionamentoContext : DbContext
    {
        public EstacionamentoContext (DbContextOptions<EstacionamentoContext> options)
            : base(options)
        {
        }

        public DbSet<Estacionamento.Models.Carro> Carro { get; set; }

        public DbSet<Estacionamento.Models.Vaga> Vaga { get; set; }
    }
}
