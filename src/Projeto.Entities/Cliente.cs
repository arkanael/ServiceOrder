﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Entities
{
    public class Cliente
    {
        public Guid IdCliente { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }

    }
}
