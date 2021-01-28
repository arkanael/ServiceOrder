using Projeto.Entities;
using Projeto.Infraestructure.Data.Context;
using Projeto.Infraestructure.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infraestructure.Data.Repositories
{
    public class TecnicoRepository : BaseRepository<Tecnico>, ITecnicoRepository
    {
        public TecnicoRepository(DataContext context)
          : base(context)
        {

        }
    }
}
