using System;

namespace SistemaCobranca.Domain
{
    public class Cobranca
    {
        public Cobranca(int id, DateTime dataEmissao, DateTime dataVenc, double valor)
        {
            Id = id;
            DataEmissao = dataEmissao;
            DataVenc = dataVenc;
            Valor = valor;  
        }

        public int Id { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVenc { get; set; }
        public double Valor { get; set; }
        public DateTime DataPgto { get; set; }

        public override string ToString()
        {
            return $"Id: {this.Id} Valor: {this.Valor}";
        }
    }
}