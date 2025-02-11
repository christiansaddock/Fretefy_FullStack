using Fretefy.Test.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Fretefy.Test.Infra.EntityFramework.Mappings
{
    public class RegiaoMap : IEntityTypeConfiguration<Regiao>
    {
        public void Configure(EntityTypeBuilder<Regiao> builder)
        {     
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Nome)
                   .IsRequired() 
                   .HasMaxLength(100);

            builder.HasMany(r => r.Cidades)
                   .WithOne(c => c.Regiao) 
                   .HasForeignKey(c => c.RegiaoId) 
                   .OnDelete(DeleteBehavior.Cascade);

            var regiaoNorteId = Guid.NewGuid();
            var regiaoNordesteId = Guid.NewGuid();
            var regiaoCentroOesteId = Guid.NewGuid();
            var regiaoSudesteId = Guid.NewGuid();
            var regiaoSulId = Guid.NewGuid();

           builder.HasData(
           new Regiao { Id = regiaoNorteId, Nome = "Região Norte" },
           new Regiao { Id = regiaoNordesteId, Nome = "Região Nordeste" },
           new Regiao { Id = regiaoCentroOesteId, Nome = "Centro Oeste" },
           new Regiao { Id = regiaoSudesteId, Nome = "Região Sudeste" },
           new Regiao { Id = regiaoSulId, Nome = "Região Sul" });

        }
    }
}
