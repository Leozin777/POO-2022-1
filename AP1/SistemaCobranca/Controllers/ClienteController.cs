using System;
using SistemaCobranca.Domain;
using SistemaCobranca.Services;

namespace SistemaCobranca.Controllers
{
    public class ClienteController
    {
        ClienteService controle = new ClienteService();

        public void Menu()
        {
            String Operador = String.Empty;

            while (Operador != "0")
            {
                Console.WriteLine("Digite 1 para adicionar um cliente");
                Console.WriteLine("Digite 2 para listar os clientes");
                Console.WriteLine("Digite 3 para buscar um cliente por Id");
                Console.WriteLine("Digite 4 para buscar um cliente por nome");
                Console.WriteLine("Digite 0 para sair do programa");

                Operador = Console.ReadLine();

                switch (Operador)
                {
                    case "0":
                        Environment.Exit(0);
                    break;

                    case "1":
                        Console.WriteLine("Digite o nome do cliente");
                        String nome = Console.ReadLine();

                        Console.WriteLine("Digite o telefone do cliente");
                        String telefone = Console.ReadLine();

                        String retorno = controle.CriarCliente(nome, telefone);

                        Console.WriteLine(retorno);
                    break;

                    case "2":
                        var lista = controle.ListarCliente();

                        Console.WriteLine(lista);
                    break;

                    case "3":
                        Console.WriteLine("Digite o Id do cliente que deseja buscar");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine(controle.BuscarId(id));
                    break;

                    case "4":
                        Console.WriteLine("Digite o nome do cliente que deseja buscar");
                        String busca = Console.ReadLine();
                        Console.WriteLine(controle.BuscarNome(busca));
                    break;

                    default:
                        Console.WriteLine("opção inválida");
                    continue;                        

                }
            } 
        }
    }
}