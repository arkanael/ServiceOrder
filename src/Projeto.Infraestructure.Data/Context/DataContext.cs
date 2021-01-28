using Microsoft.EntityFrameworkCore;
using Projeto.Entities;
using Projeto.Infraestructure.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Text;
namespace Projeto.Infraestructure.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> builder): base(builder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new OrdemServicoMap());
            modelBuilder.ApplyConfiguration(new ServicoMap());
            modelBuilder.ApplyConfiguration(new TecnicoMap());
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<OrdemServico> OrdemServico { get; set; }
        public DbSet<Servico> Servico { get; set; }
        public DbSet<Tecnico> Tecnico { get; set; }
    }
}
