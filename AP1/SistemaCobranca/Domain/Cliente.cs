using System;

namespace SistemaCobranca.Domain
{
    public class Cliente
    {
        public Cliente(int id, String nome, String telefone)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
        }

        public int Id { get; set; }
        public String Nome { get; set; }
        public String Telefone { get; set; }


    }
}