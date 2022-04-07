using System;
using AgendaContatos.Data;
using AgendaContatos.Domain;

namespace AgendaContatos.Services
{
    public class ContatoService
    {
        ContatoRepository minhaAgenda = new ContatoRepository();


        public int TamList()
        {
            return minhaAgenda.GetAll().Count;
        }
        public String CriarContato(String nome, String tel)
        {
            int idContato = TamList() + 1;
            minhaAgenda.Save(new Contato(idContato, nome, tel));

            return "Contato add com sucesso";
        }
    }
}