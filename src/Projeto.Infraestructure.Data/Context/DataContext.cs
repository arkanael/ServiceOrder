using Microsoft.EntityFrameworkCore;
using Projeto.Infraestructure.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Text;
namespace Projeto.Infraestructure.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> builder)
           : base(builder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
