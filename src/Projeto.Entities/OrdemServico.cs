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

        public Boolean resolvido { get; set; }
    }
}
