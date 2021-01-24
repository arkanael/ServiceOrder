using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Entities
{
    public class OrdemServico
    {
        public Guid IdOrdemServico { get; set; }
        public DateTime DataAtendimento { get; set; }
        public DateTime DataAgendamento { get; set; }
        public Boolean Status { get; set; }

        #region Relacionamento
        public Endereco Endereco { get; set; }
        public Guid IdEndereco { get; set; }
        public Cliente Cliente { get; set; }
        public Guid IdCliente { get; set; }
        public Tecnico Tecnico { get; set; }
        public Guid IdTecnico { get; set; }
        #endregion

    }
}
