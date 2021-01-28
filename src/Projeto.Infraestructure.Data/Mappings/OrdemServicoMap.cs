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

            builder.Property(x => x.DataAbertura)
                .HasColumnType("date")
                .IsRequired(false);

            builder.Property(x => x.DataAgendamento)
                .HasColumnType("date")
                .IsRequired();

            builder.Property(x => x.DataFechamento)
                .HasColumnType("date")
                .IsRequired();

            builder.Property(x => x.IdCliente)
                .IsRequired();

            builder.Property(x => x.IdEndereco)
               .IsRequired();

            builder.Property(x => x.IdTecnico)
               .IsRequired();

            #region Relacionamentos
            builder.HasOne(x => x.Cliente)
              .WithMany(x => x.OrdemServicos)
              .HasForeignKey(x => x.IdCliente)
              .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(x => x.Endereco)
               .WithMany(x => x.OrdemServicos)
               .HasForeignKey(x => x.IdEndereco)
               .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(x => x.Tecnico)
               .WithMany(x => x.OrdemServicos)
               .HasForeignKey(x => x.IdTecnico)
               .OnDelete(DeleteBehavior.ClientCascade);

            #endregion

        }
    }
}
