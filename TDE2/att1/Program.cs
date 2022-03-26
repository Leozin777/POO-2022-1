using System;
using System.Collections.Generic;
/*
Identifique	 as classes e implemente um	 programa para a seguinte especificação:
“O supermercado	 vende diferentes tipos de produtos. Cada produto tem um preço e uma
quantidade em estoque. Um pedido de um cliente é composto de itens,	onde cada item específica 
o produto que o cliente deseja e a respectiva quantidade. Esse pedido pode ser pago em dinheiro, cheque ou cartão.” 
*/
namespace att1
{
    class Program
    {
        static Pedido pedidoDoJoel;

        static void Main(string[] args)
        {
            Produto arroz = new Produto(001, "Arroz", 67);
            Produto cafe = new Produto(002, "Café", 86);
            Produto agua = new Produto(003, "Água", 86);

            Cliente Cjoel = new Cliente(1, "Joel");

            FormaPagamento fCartao = new FormaPagamento(100, "cartão");
            FormaPagamento fDinheiro = new FormaPagamento(1001, "dinheiro");

            //criando um pedido
            pedidoDoJoel = new Pedido(1, 
                new DateTime(2022,03,01),
                Cjoel,
                new List<Produto>()
                {
                    arroz,
                    cafe
                });

            pedidoDoJoel.Produtos.Add(agua);
            pedidoDoJoel.FormaPagamentos.Add(fDinheiro);
            pedidoDoJoel.FormaPagamentos.Add(fCartao);

            //imprimir pedido
            ImprimirPedido();

        }

        private static void ImprimirPedido()
        {
            Console.WriteLine("Pedido do " + pedidoDoJoel.Cliente.Nome);
            Console.WriteLine("Data " + pedidoDoJoel.Data.ToString("dd/MM/yyyy"));
            Console.WriteLine("--------------------------");

            foreach (var item in pedidoDoJoel.Produtos)
            {
                Console.WriteLine(item.Nome);
            }

             foreach (var item in pedidoDoJoel.FormaPagamentos)
            {
                Console.WriteLine(item.Nome);
            }
        }

    }
}
