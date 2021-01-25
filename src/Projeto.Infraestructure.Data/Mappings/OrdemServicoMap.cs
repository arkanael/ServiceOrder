using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infraestructure.Data.Mappings
{
    public class OrdemServicoMap : IEntityTypeConfiguration<OrdemServico>
    {
        public void Configure(EntityTypeBuilder<OrdemServico> builder)
        {
            builder.ToTable("OrdemServico");

            builder.HasKey(x => x.IdOrdemServico);

            builder.Property(x => x.IdCliente)
                .IsRequired();

            builder.Property(x => x.DataAbertatura)
                .HasColumnType("date")
                .IsRequired(false);

            builder.Property(x => x.DataAgendamento)
                .HasColumnType("date")
                .IsRequired();

            builder.Property(x => x.DataFechamento)
                .HasColumnType("date")
                .IsRequired();
        }
    }
}
