using System.Collections.Generic;
using AgendaContatos.Domain;

namespace AgendaContatos.Data
{
    public class ContatoRepository
    {
        private List<Contato> listaDeContatos = new List<Contato>();

        public List<Contato> GetAll()
        {
            return listaDeContatos;
        }

        public void Save(Contato contato)
        {
            listaDeContatos.Add(contato);
        }

        public Contato GetById(int idContato)
        {
            return listaDeContatos.Find(p => p.Id == idContato);
        }

        public void Update(Contato contato)
        {
            var contatoEditado = GetById(contato.Id);
            contatoEditado.Nome = contato.Nome;
            contatoEditado.Tel = contato.Tel;
        }

        public void Delete(Contato contato)
        {
            listaDeContatos.Remove(contato);
        }
    }
}