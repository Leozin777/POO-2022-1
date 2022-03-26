namespace att1
{
    public class Produto
    {
        public Produto(int id, string nome, double preco, double quantEstoque = 0)
        {
            Id = id;
            Nome = nome;
            QuantEstoque = quantEstoque;
            Preco = preco;
        }

        public int Id { get; private set; }
        public string Nome { get; set; }
        public double QuantEstoque { get; set; } = 0;
        public double Preco { get; private set; }
        

    }
}