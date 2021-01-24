using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Entities
{
    public class Tecnico
    {
        public Guid IdTecnico { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        #region Relacionamento
        public List<OrdemServico> OrdemServicos { get; set; }
        #endregion
    }
}
