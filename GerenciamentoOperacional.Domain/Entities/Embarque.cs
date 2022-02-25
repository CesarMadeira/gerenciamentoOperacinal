using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoOperacional.Domain.Entities
{
    public class Embarque : EntityBase
    {
        public string Booking { get; set; }
        public string Instrucao { get; set; }
        public int QuandidadeContainer { get; set; }
        public DateTime DeadLineDraft { get; set; }
        public DateTime DeadLineCarga { get; set; }
        public int ClienteExportadorId { get; set; }
        public int AgenteCargaId { get; set; }
        public int IndicadoId { get; set; }
        public int FaturadoId { get; set; }
        public int InspetoriaId { get; set; }
        public int TipoContainerId { get; set; }
        public int TerminalEmbarqueId { get; set; }
        public int TerminalEstufagemId { get; set; }
        public int PortoDestinoId { get; set; }
        public int NavioId { get; set; }

        public ICollection<Container> Containers { get; set; }

        public virtual Empresa ClienteExportador { get; set; }
        //public virtual Empresa AgenteCarga { get; set; }
        //public virtual Empresa Indicado { get; set; }
        //public virtual Empresa Faturado { get; set; }
        //public virtual Empresa Inspetoria { get; set; }
        //public virtual TipoContainer TipoContainer { get; set; }
        //public virtual Terminal TerminalEmbarque { get; set; }
        //public virtual Terminal TerminalEstufagem { get; set; }
        //public virtual Porto PortoDestino { get; set; }
        //public virtual Navio Navio { get; set; }
    }
}
