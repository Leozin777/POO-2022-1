using System;
using System.Text;
using SistemaCobranca.Data;
using SistemaCobranca.Domain;

namespace SistemaCobranca.Services
{
    public class ClienteService
    {
        ClienteRepository repositorioCliente = new ClienteRepository();

        public int TamaLista()
        {
            return repositorioCliente.GetAll().Count;
        }
        public String CriarCliente(String Nome, String Telefone)
        {
            int id = TamaLista() + 1;
            Cliente cliente = new Cliente(id, Nome, Telefone);
            repositorioCliente.Save(cliente);
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
                    builder.AppendLine($"Nome: {cliente.Nome} || Id: {cliente.Id} || Telefone {cliente.Telefone}");
                }
            }

            return builder.ToString();
        }

        public String BuscarId(int id)
        {
            var builder = new StringBuilder();
            var cliente = repositorioCliente.GetById(id); 
            
            if(cliente is Cliente)
                builder.AppendLine($"Nome: {cliente.Nome} Id: {cliente.Id} Telefone: {cliente.Telefone}");
            else
            {
                builder.AppendLine("Esse cliente não existe");
            }

            return builder.ToString();

        }

        public String BuscarNome(String nome)
        {
            var builder = new StringBuilder();
            var cliente = repositorioCliente.GetByName(nome); 
            
            if(cliente is Cliente)
                builder.AppendLine($"Nome: {cliente.Nome} Id: {cliente.Id} Telefone: {cliente.Telefone}");
            else
            {
                builder.AppendLine("Esse cliente não existe");
            }

            return builder.ToString();
        }

        public String EditarCliente(String nome, int id, String telefone)
        {
            String retorno;


            if(TamaLista().Equals(0))
            {
                retorno = "Lista vazia, para poder editar um cliente é necessário ter um cliente cadastrado.";
                return retorno;
            }
            var cliente = repositorioCliente.GetById(id);

            if(cliente == null)
            {
                retorno = "Cliente não encontrado";
                return retorno;
            }

            repositorioCliente.Update(new Cliente(id, nome, telefone));
            retorno = "Cliente editado com sucesso!!!";
            return retorno;
        }

        public String ExcluirCliente(int id)
        {
            String retorno3;
            var clienteExcluir = repositorioCliente.GetById(id);
            repositorioCliente.Delete(clienteExcluir);

            retorno3 = "Cliente excluido";

            return retorno3;
        }

        
    }
}