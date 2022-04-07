using System;
using System.Collections.Generic;

namespace AgendaTel.Domain
{
    public class Agenda
    {
        public Agenda(List<Contato> contato)
        {
            this.contato = contato;
        }

        public List<Contato> contato { get; set; }


        public void buscarId(int id, List<Contato> contatos)
        {
            foreach (Contato c in contatos)
            {
                if(id == c.Id)
                {
                    msgSucess(c.Nome, c.Num);
                }else
                {
                    msgFail();
                }
            }
        }
        public void buscarNome(string nome, List<Contato> contatos)
        {
            foreach (Contato c in contatos)
            {
                if(nome == c.Nome)
                {
                    msgSucess(c.Nome, c.Num);
                }else
                {
                    msgFail();
                }    
            }
        }

        public void buscarNum(long num, List<Contato> contatos)
        {
            foreach (Contato c in contatos)
            {
                if(num == c.Num)
                {
                    msgSucess(c.Nome, c.Num);
                }else
                {
                    msgFail();
                } 
            }
        }

        public static void msgSucess(string nome, long num)
        {
            Console.WriteLine("Nome: " + nome + ", número de telefone: " + num);
        }

        public static void msgFail()
        {
            Console.WriteLine("Esta pessoa não existe na agenda :/");
        }
    }
}