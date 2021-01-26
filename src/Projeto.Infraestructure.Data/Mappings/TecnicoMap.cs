using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infraestructure.Data.Mappings
{
    public class TecnicoMap : IEntityTypeConfiguration<Tecnico>
    {
        void IEntityTypeConfiguration<Tecnico>.Configure(EntityTypeBuilder<Tecnico> builder)
        {
            builder.ToTable("Tecnico");

            builder.HasKey(x => x.IdTecnico);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(80)
                .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Telefone)
                .HasColumnType("varchar")
                .HasMaxLength(15)
                .IsRequired();
        }
    }
}
