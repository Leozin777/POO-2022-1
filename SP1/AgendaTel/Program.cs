using System;
using System.Collections.Generic;

/*
Identifique os atributos de  uma agenda	telefônica, modele as classes, atributos e métodos necessários para a futura implementação.
*/

namespace AgendaTel
{
    class Program
    {
        static async void Main(string[] args)
        {
            Contato leo = new Contato(100, "Leonardo", 5183252525);
            Contato joao = new Contato(102, "Joao", 5185871285);
            Contato paulo = new Contato(103, "Paulo", 5182239774);
            Contato joana = new Contato(104, "Joana", 5182256774);

            Agenda agendaTelefonica = new Agenda(
                new List<Contato>()
                {
                    leo,
                    joao,
                    paulo
                }
            );

            
        }
    }
}
