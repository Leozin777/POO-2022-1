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
            Produto arroz = new Produto(001, "Arroz", 67, 12.99);
            Produto cafe = new Produto(002, "Café", 86, 17.99);
            Produto agua = new Produto(003, "Água", 86, 1.99);
            Produto acucar = new Produto(004, "Açucar", 32, 5.99);

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
                    acucar
                });

            pedidoDoJoel.Produtos.Add(agua);
            VeriEst(agua, 3);
            pedidoDoJoel.FormaPagamentos.Add(fDinheiro);
            pedidoDoJoel.FormaPagamentos.Add(fCartao);

            //imprimir pedido
            ImprimirPedido();

        }

        private static void ImprimirPedido()
        {
            Console.WriteLine("Pedido do " + pedidoDoJoel.Cliente.Nome);
            Console.WriteLine("Data " + pedidoDoJoel.Data.ToString("dd/MM/yyyy"));
            Console.WriteLine("Código do cliente: " + pedidoDoJoel.Id);
            Console.WriteLine("--------------------------");

            Console.WriteLine("Produtos:");
            foreach (var item in pedidoDoJoel.Produtos)
            {
                Console.WriteLine( "Código do produto: " + item.Id + " // Nome do produto " + item.Nome);
            }

             foreach (var item in pedidoDoJoel.FormaPagamentos)
            {
                Console.WriteLine(item.Nome);
            }
        }

        private static Boolean VeriEst(Produto produto, int quant)
        {
            if(produto.QuantEstoque >= quant){
                return true;
            } else{
                return false;
            }
        }

        private static void Total(Produto produto)
        {
            
        }



    }
}
