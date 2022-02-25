using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoOperacional.Domain.Entities
{
    public class ServicoItem : EntityBase
    {
        public string Nome { get; set; }
        public bool Feito { get; set; }
        public virtual Servico Servico { get; set; }
    }
}
