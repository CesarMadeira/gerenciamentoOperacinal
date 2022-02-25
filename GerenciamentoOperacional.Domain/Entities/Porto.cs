using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoOperacional.Domain.Entities
{
    public class Porto : EntityBase
    {
        public string Nome { get; set; }
        public string Cidade { get; set; } 
        public string Pais { get; set; }
    }
}
