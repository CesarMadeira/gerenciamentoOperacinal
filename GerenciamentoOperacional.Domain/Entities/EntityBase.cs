using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoOperacional.Domain.Entities
{
    public class EntityBase
    {
        public int ID { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Deletado { get; set; }
    }
}
