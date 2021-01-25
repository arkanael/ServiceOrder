using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Entities
{
    public class Servico
    {
        public Guid IdServico { get; set; }
        public string Tipo { get; set; } //Infraestrutura, Computador, Impressora, Software e etc.
        public string Descricao { get; set; } //Ex. 1: Computador não liga, Ex. 2: Não consigo abrir arquivos *.PDF
        public decimal Preco { get; set; }
    }
}
