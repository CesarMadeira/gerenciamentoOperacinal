using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoOperacional.Domain.Entities
{
    public class EmbarqueServico
    {
        public int EmbarqueId { get; set; }
        public Embarque Embarque { get; set; }
        public int ServicoId { get; set; }
        public Servico Servico { get; set; }
    }
}
