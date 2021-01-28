using Projeto.Entities;
using Projeto.Infraestructure.Data.Context;
using Projeto.Infraestructure.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infraestructure.Data.Repositories
{
    public class ServicoRepository : BaseRepository<Servico>, IServicoRepository
    {
        public ServicoRepository(DataContext context)
          : base(context)
        {

        }
    }
}
