using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoOperacional.Domain.Entities
{
    public class Container: EntityBase
    {
        public string Numero { get; set; }
        public DateTime DataRetirada { get; set; }
        public Terminal TerminalRetirada { get; set; }
        public string NotaFiscalExportacao { get; set; }
        public string Lacre { get; set; }
        public string Lote { get; set; }
        public decimal Tara { get; set; }
        public decimal MGW { get; set; }
        public decimal PesoBruto { get; set; }
        public decimal Fardos { get; set; }
        public decimal PesoCarga { get; set; }
        public int EmbarqueID { get; set; }

    }
}
