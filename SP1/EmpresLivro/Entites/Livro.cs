using System;

namespace EmpresLivro.Entites
{
    public class Livro
    {
        public Livro(int id, string nome, Autor autor, DateTime dataPubli, int quant)
        {
            Id = id;
            Nome = nome;
            Autor = autor;
            DataPubli = dataPubli;
            Quant = quant;
        }

        public int Id { get; private set; }
        public String Nome { get; private set; }
        public Autor Autor { get; private set; }
        public DateTime DataPubli { get; private set; }
        public int Quant { get; set; }
    }
}