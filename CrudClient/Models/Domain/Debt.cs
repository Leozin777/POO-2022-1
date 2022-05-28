namespace CrudClient.Models.Domain
{
    public class Debt
    {
        public Debt(){}
        public Debt(int id, DateTime dataEmissao, DateTime dataVencimento, bool statusPagamento, Client client)
        {
            Id = id;
            DataEmissao = dataEmissao;
            DataVencimento = dataVencimento;
            StatusPagamento = statusPagamento;
            Client = client;
        }

        public int Id { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime? DataPagamento { get; set; }
        public Boolean StatusPagamento { get; set; }
        public Client Client { get; set; }
    }
}