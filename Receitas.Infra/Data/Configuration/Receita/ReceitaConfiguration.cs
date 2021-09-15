using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Receitas.Domain.Services.Receitas.Entities;

namespace Receitas.Infra.Data.Configuration.Receitas
{
    public class ReceitaConfiguration : IEntityTypeConfiguration<ReceitaEntity>
    {
        public void Configure(EntityTypeBuilder<ReceitaEntity> builder)
        {
            builder.ToTable("Receitas");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).IsRequired();
            builder.Property(p => p.Descricao).IsRequired();
            builder.Property(p => p.Dificuldade).IsRequired();
            builder.Property(p => p.Horas).IsRequired();
        }
    }
}
