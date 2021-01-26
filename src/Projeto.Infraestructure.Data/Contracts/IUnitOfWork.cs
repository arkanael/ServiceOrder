using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infraestructure.Data.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTrasaction();
        void Commit();
        void Rollback();

        IClienteRepository ClienteRepository { get; }
        IEnderecoRepository EnderecoRepository { get; }
        IOrdemServicoRepository OrdemServicoRepository { get; }
        IServicoRepository ServicoRepository { get; }
        ITecnicoRepository TecnicoRepository { get; }
    }
}
