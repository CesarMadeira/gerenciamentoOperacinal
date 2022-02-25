using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciamentoOperacional.Domain.Entities
{
    public class Veiculo : EntityBase
    {
        public string Placa { get; set; }
        public string Motorista { get; set; }
        public int TipoCargaId { get; set; }
        public string Booking { get; set; }
        public string NotasFsicais { get; set; }
        public string Lote { get; set; }
        public string Fardos { get; set; }
        public decimal ValorNotasFiscais { get; set; }
        public decimal Peso { get; set; }
        public DateTime Chegada { get; set; }
        public DateTime Registro { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public decimal ValorTonelada { get; set; }
        public int ClienteExportadorId { get; set; }
        public int OperadorLogisticoId { get; set; }
        public int TransportadoraId { get; set; }
        public virtual TipoCarga TipoCarga { get; set; }
    }
}
