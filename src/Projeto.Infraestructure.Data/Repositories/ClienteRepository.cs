using Projeto.Entities;
using Projeto.Infraestructure.Data.Context;
using Projeto.Infraestructure.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infraestructure.Data.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        
        public ClienteRepository(DataContext context)
            :base(context) 
        {
            
        }
    }
}
