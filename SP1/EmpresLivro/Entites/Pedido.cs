using System;
using System.Collections.Generic;

namespace EmpresLivro.Entites
{
    public class Pedido
    {
        public Pedido(int id, Pessoa pessoa, DateTime data, List<Livro> livrosE)
        {
            Id = id;
            Pessoa = pessoa;
            Data = data;
            LivrosE = livrosE;
        }

        public int Id { get; private set; }
        public Pessoa Pessoa { get; set; }  
        public DateTime Data { get; set; }
        public List<Livro> LivrosE { get; set; }
    }
}