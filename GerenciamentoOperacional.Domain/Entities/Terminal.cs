using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoOperacional.Domain.Entities
{
    public class Terminal : EntityBase
    {
        public string Nome { get; set; }
        public int PortoId { get; set; }

        public virtual Porto Porto { get; set; }
    }
}
