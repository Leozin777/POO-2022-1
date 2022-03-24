using System;
using aula1.Entities;
namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Autor autor = new Autor(10, "carlos");

            Livro objLivro = new Livro(11, "livro bom", autor);

            Console.WriteLine(
                objLivro.GetId() + " - " +
                objLivro.GetTitulo() + " - " +
                objLivro.GetValor() + " - " +
                objLivro.Autor.Nome
            );

            objLivro.SetValor(30);
            Console.WriteLine(
                objLivro.GetValor()
            );
        }
    }
}
