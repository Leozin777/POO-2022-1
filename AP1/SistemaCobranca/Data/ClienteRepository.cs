using System;
using System.Collections.Generic;
using SistemaCobranca.Domain;

namespace SistemaCobranca.Data
{
    public class ClienteRepository
    {
        private List<Cliente> listaDeCliente = new List<Cliente>();

        public List<Cliente> GetAll()
        {
            return listaDeCliente;
        }

        public void Save(Cliente cliente)
        {
            listaDeCliente.Add(cliente);
        }

        public Cliente GetById(int idCliente)
        {
            return listaDeCliente.Find(p => p.Id == idCliente);
        }

        public Cliente GetByName(String nomeCliente)
        {
            return listaDeCliente.Find(p => p.Nome == nomeCliente);
        }

        public void Delete(Cliente cliente)
        {
            listaDeCliente.Remove(cliente);
        }

    }
}