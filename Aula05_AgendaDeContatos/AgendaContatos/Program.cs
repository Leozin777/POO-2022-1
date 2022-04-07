using System;
using AgendaContatos.Controllers;

namespace AgendaContatos
{
    class Program
    {
        static void Main(string[] args)
        {
            ContatoController agenda = new ContatoController();
            agenda.Menu();
        }
    }
}
