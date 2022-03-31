using System;
using System.Collections.Generic;

namespace AgendaTel
{
    public class Contato
    {
        public Contato(int id, string nome, long num)
        {
            this.Id = id;
            this.Nome = nome;
            this.Num = num;
        }
        public int Id { get; private set; }
        public String Nome { get; private set; }
        public long Num { get; set; }

    }
}
