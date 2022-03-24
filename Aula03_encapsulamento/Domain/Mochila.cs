using System.Collections.Generic;

namespace Aula03_encapsulamento.Domain
{
    public class Mochila
    {
        public Mochila(int id, string nome, string descricao, decimal preco, int quantMax, eCor cor)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.Preco = preco;
            this.QuantMax = quantMax;
            this.Cor = Cor;

        }
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; set; }
        public int QuantMax { get; private set; }
        public eCor Cor { get; set; }

        public List<Item> Itens { get; set; }

    }
}