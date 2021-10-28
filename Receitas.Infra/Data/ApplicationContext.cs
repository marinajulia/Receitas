using Microsoft.EntityFrameworkCore;
using Receitas.Domain.Services.ReceitaFotos.Entities;
using Receitas.Domain.Services.Receitas.Entities;

namespace Receitas.Infra.Data
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-SN81A5J\SQLEXPRESS;Initial Catalog=Receitas;Integrated Security=True");
        }
        public DbSet<ReceitaEntity> Receitas { get; set; }
        public DbSet<ReceitaFotosEntity> ReceitaFotos { get; set; }
    }
}