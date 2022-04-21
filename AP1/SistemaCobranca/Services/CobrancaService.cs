using System;
using System.Text;
using SistemaCobranca.Data;
using SistemaCobranca.Domain;

namespace SistemaCobranca.Services
{
    public class CobrancaService
    {
        CobrancaRepository repositorioCobranca = new CobrancaRepository();
        ClienteRepository repositorioCliente = new ClienteRepository();

         public int TamaLista()
        {
            return repositorioCobranca.GetAll().Count;
        }
        public string AddCobranca(DateTime dataEmissao, DateTime dataVenc, double valor, int clienteId)
        {
            int cobrancaId = repositorioCobranca.GetAll().Count + 1;
            var cliente = repositorioCliente.GetById(clienteId);
            if(cliente == null)
                return "Cliente não encontrado";
            else
            {
                repositorioCobranca.Save(new Cobranca(cobrancaId, dataEmissao, dataVenc, valor, cliente));
                return "Cobrança adicionada com sucesso";
            }
        }

        public String ListarCobranca()
        {
            var builder = new StringBuilder();
            var listaDeCobranca = repositorioCobranca.GetAll();
            var qtdCobranca = listaDeCobranca.Count;

            if(qtdCobranca == 0)
                builder.AppendLine("Lista vazia");
            else
            {
                foreach (Cobranca cobranca in listaDeCobranca)
                {
                    builder.AppendLine($"Id: {cobranca.Id} || Data de Emissão: {cobranca.DataEmissao} || Data de Vencimento: {cobranca.DataVenc}");
                }
            }

            return builder.ToString();
        }
    }
}