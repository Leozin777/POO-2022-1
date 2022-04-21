using System;

namespace SistemaCobranca.Domain
{
    public class Cobranca
    {
        public Cobranca(int id, DateTime dataEmissao, DateTime dataVenc, double valor, Cliente cliente)
        {
            Id = id;
            DataEmissao = dataEmissao;
            DataVenc = dataVenc;
            Valor = valor; 
            DataPgto = null; 
            Cliente = cliente;
        }

        public int Id { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVenc { get; set; }
        public double Valor { get; set; }
        public DateTime? DataPgto { get; set; }

        public Cliente Cliente { get; set; }

        public override string ToString()
        {
            return $"Id: {this.Id} Valor: {this.Valor}";
        }
    }
}