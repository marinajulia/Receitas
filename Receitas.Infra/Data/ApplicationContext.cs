using Microsoft.EntityFrameworkCore;
using Receitas.Domain.Services.ReceitaFotos.Entities;
using Receitas.Domain.Services.Receitas.Entities;

namespace Receitas.Infra.Data
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-8024PRG\SERVIDOR;Initial Catalog=Receitas;Integrated Security=True");
        }
        public DbSet<ReceitaEntity> Receitas { get; set; }
        public DbSet<ReceitaFotosEntity> ReceitaFotos { get; set; }
    }
}