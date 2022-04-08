using System;
using SistemaCobranca.Controllers;

namespace SistemaCobranca
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteController Cliente = new ClienteController();
            Cliente.Menu();
        }
    }
}
