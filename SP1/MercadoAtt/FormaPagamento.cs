namespace att1
{
    public class FormaPagamento
    {
        public FormaPagamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
    }
}