namespace att1
{
    public class Produto
    {
        public Produto(int id, string nome, double quantEstoque = 0)
        {
            Id = id;
            Nome = nome;
            QuantEstoque = quantEstoque;
        }

        public int Id { get; private set; }
        public string Nome { get; set; }
        public double QuantEstoque { get; set; } = 0;
        

    }
}