using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoOperacional.Domain.Entities
{
    public class Navio : EntityBase
    {
        public string Nome { get; set; }
        public string Armador { get; set; }
    }
}
