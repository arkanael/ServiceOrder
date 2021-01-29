using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infraestructure.Data.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
        void SaveChanges();

        IClienteRepository ClienteRepository { get; }
        IEnderecoRepository EnderecoRepository { get; }
        IOrdemServicoRepository OrdemServicoRepository { get; }
        ITecnicoRepository TecnicoRepository { get; }
    }
}
