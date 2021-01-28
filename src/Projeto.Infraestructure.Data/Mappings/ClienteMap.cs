using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infraestructure.Data.Mappings
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(x => x.IdCliente);

            builder.Property(x => x.IdCliente)
                .IsRequired();

            builder.Property(x => x.RazaoSocial)
                .HasColumnType("varchar")
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.NomeFantasia)
               .HasColumnType("varchar")
               .HasMaxLength(250)
               .IsRequired();

            builder.Property(x => x.CNPJ)
               .HasColumnType("char")
               .HasMaxLength(14)  
               .IsRequired();

        }
    }
}
