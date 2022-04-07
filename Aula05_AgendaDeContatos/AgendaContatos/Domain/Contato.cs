using System;

namespace AgendaContatos.Domain
{
    public class Contato
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Tel { get; set; }

        public Contato(int id,String Nome, String Tel)
        {
            this.Id = id;
            this.Nome = Nome;
            this.Tel = Tel;
        }
    }
}