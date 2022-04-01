using System;

namespace EmpresLivro.Entites
{
    public class Autor
    {
        public Autor(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; private set; }
        public String Nome { get; private set; }
    }
}