﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoOperacional.Domain.Entities
{
    public class Servico: EntityBase
    {
        public string Nome { get; set; }
        public ICollection<ServicoItem> ServicoItems { get; set; }
    }
}
