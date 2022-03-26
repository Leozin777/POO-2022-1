using System;
using System.Collections.Generic;

namespace att1
{
    public class Pedido
    {
        public Pedido(int id, DateTime data, Cliente cliente, List<Produto> produtos)
        {
            Id = id;
            Data = data;
            Cliente = cliente;
            Produtos = produtos;
            FormaPagamentos = new List<FormaPagamento>();
             
        }

        public int Id { get; private set; }
        public DateTime Data { get; set; }
        public Cliente Cliente { get; set; }
        public List<Produto> Produtos { get; set; }
        public List<FormaPagamento> FormaPagamentos { get; set; }
    }
}