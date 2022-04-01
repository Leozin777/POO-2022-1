using System;
using System.Collections.Generic;

namespace EmpresLivro.Entites
{
    public class Pessoa
    {
        public Pessoa(int id, string nome, string endereco)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
        }

        public int Id { get; set; }
        public String Nome { get; set; }
        public String Endereco { get; set; }
    }
}