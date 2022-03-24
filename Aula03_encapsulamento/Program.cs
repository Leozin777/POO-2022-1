using System;
using Aula03_encapsulamento.Domain;

namespace Aula03_encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteMsg("Criar obj mochila");

            Mochila mp = new Mochila(1, "Mochila","Mochila de notebook", 200, 10, eCor.Amarelo);
            WriteMsg("Nome: " + mp.Nome);
            

            Item celular = new Item(100, "Nokia 3030");
            Item caneta = new Item(99, "Caneta azul");


            mp.Itens.Add(celular);
            mp.Itens.Add(caneta);

            WriteMsg("itens");
            foreach (var item in mp.Itens)
            {
                
            }
        }

        private static void WriteMsg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
