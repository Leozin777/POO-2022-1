using System;

namespace SistemaCobranca.Domain
{
    public class Cobranca
    {
        public Cobranca(int id, DateTime dataEmissao, DateTime dataVenc, string valor, DateTime dataPgto)
        {
            Id = id;
            DataEmissao = dataEmissao;
            DataVenc = dataVenc;
            Valor = valor;
            DataPgto = dataPgto;
        }

        public int Id { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVenc { get; set; }
        public String Valor { get; set; }
        public DateTime DataPgto { get; set; }
    }
}