using System;
using AgendaContatos.Services;

namespace AgendaContatos.Controllers
{
    public class ContatoController
    {
        ContatoService controle = new ContatoService();

        public void Menu()
        {
            String operador = String.Empty;

            while(operador != "0")
            {
                Console.WriteLine("Digite 1 para add um novo contato");
                Console.WriteLine("Digite 2 para listar todos os contatos");
                Console.WriteLine("Digite 0 para sair da aplicação");
                


                operador = Console.ReadLine();

                switch (operador)
                {
                    case "0":
                        Environment.Exit(0);
                    break;

                    case "1":
                        Console.WriteLine("Digite o nome do contato");
                        String nome = Console.ReadLine().Trim();

                        Console.WriteLine("Digite o telefone do contato");
                        String tel = Console.ReadLine().Trim();

                        String retorna = controle.CriarContato(nome, tel);

                        Console.WriteLine(retorna);
                    break;

                    case "2":
                        var retorna2 = controle.ListarContatos();
                        Console.WriteLine(retorna2);
                    break;

                    default:
                        Console.WriteLine("opção inválida");
                    continue;
                }
            }
        }
    }
}