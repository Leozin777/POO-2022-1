using System;
using System.Text;
using SistemaCobranca.Data;
using SistemaCobranca.Domain;

namespace SistemaCobranca.Services
{
    public class ClienteService
    {
        ClienteRepository repositorioCliente = new ClienteRepository();


        public int RetornaProxId()
        {
            return repositorioCliente.GetAll().Count + 1;
        }
        public String CriarCliente(String Nome, String Telefone)
        {
            repositorioCliente.Save(new Cliente(RetornaProxId(), Nome, Telefone));
            return "Cliente adicionado com sucesso";
        }

        public String ListarCliente()
        {
            var builder = new StringBuilder();
            var listaDeCliente = repositorioCliente.GetAll();
            var qtdCliente = listaDeCliente.Count;

            if(qtdCliente == 0)
                builder.AppendLine("Lista vazia");
            else
            {
                foreach (Cliente cliente in listaDeCliente)
                {
                    builder.AppendLine($"Nome: {cliente.Nome}   Id: {cliente.Id}");
                }
            }

            return builder.ToString();
        }

        public Cliente BuscarId(int id)
        {
            return repositorioCliente.GetById(id); 
        }

        public Cliente BuscarNome(String nome)
        {
            return repositorioCliente.GetByName(nome); 
        }
    }
}