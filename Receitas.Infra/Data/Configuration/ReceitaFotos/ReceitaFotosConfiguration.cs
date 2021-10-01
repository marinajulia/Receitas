using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Receitas.Domain.Services.ReceitaFotos.Entities;

namespace Receitas.Infra.Data.Configuration.ReceitaFotos
{
    public class ReceitaFotosConfiguration : IEntityTypeConfiguration<ReceitaFotosEntity>
    {
        public void Configure(EntityTypeBuilder<ReceitaFotosEntity> builder)
        {
            builder.ToTable("ReceitaFotos");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.IdReceita);
            builder.Property(p => p.File).IsRequired();
            //builder.Property(p => p.Format).IsRequired();
        }
    }
}
