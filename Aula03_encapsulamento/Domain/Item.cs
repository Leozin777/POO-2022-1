namespace Aula03_encapsulamento.Domain
{
    public class Item
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public Mochila Mochila { get; set; }
    
        public Item(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }
    }    
}