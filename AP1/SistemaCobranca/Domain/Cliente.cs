using System;
using System.Collections.Generic;

namespace SistemaCobranca.Domain
{
    public class Cliente
    {
        public Cliente(int id, String nome, String telefone)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Cobrancas = new List<Cobranca>();
        }

        public int Id { get; set; }
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public List<Cobranca> Cobrancas { get; set; }
    }
}