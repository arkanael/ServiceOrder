using Microsoft.EntityFrameworkCore.Storage;
using Projeto.Infraestructure.Data.Context;
using Projeto.Infraestructure.Data.Contracts;
using Projeto.Infraestructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infraestructure.Data.Mappings
{
    public class UnitOfwork : IUnitOfWork
    {
        private readonly DataContext context;
        private IDbContextTransaction transaction;
        
        public UnitOfwork(DataContext context)
        {
            this.context = context;
        }

        public void BeginTransaction()
        {
            transaction = context.Database.BeginTransaction();
        }

        public void Commit()
        {
            if (transaction != null)
            {
                transaction.Commit();
            }
        }

        public void Rollback()
        {
            if (transaction != null)
            {
                transaction.Rollback();
            }
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
        public IClienteRepository ClienteRepository => new ClienteRepository(context);

        public IEnderecoRepository EnderecoRepository =>  new EnderecoRepository(context);

        public IOrdemServicoRepository OrdemServicoRepository => new OrdemServicoRepository(context);

        public ITecnicoRepository TecnicoRepository =>  new TecnicoRepository(context);
    }
}
