using System;
using System.Text;
using AgendaContatos.Data;
using AgendaContatos.Domain;

namespace AgendaContatos.Services
{
    public class ContatoService
    {
        ContatoRepository minhaAgenda = new ContatoRepository();


        public int RetornaProxId()
        {
            return minhaAgenda.GetAll().Count + 1;
        }
        public String CriarContato(String nome, String tel)
        {
            minhaAgenda.Save(new Contato(RetornaProxId(), nome, tel));

            return "Contato add com sucesso";
        }

        public String ListarContatos()
        {
            var builder = new StringBuilder();
            var listaContatos = minhaAgenda.GetAll();
            var qtdContatos = listaContatos.Count;

            if(qtdContatos == 0)
                builder.AppendLine("Lista vazia");
            else
            {
                foreach (Contato contato in listaContatos)
                {
                    builder.AppendLine("Id: " + contato.Id + " nome: " + contato.Nome);
                }
            }

            return builder.ToString();

            
        }
    }
}