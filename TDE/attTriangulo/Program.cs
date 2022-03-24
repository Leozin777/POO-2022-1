using System;
using attTriangulo.Entities;

        /*
        Gere uma classe que lerá as informações de base e altura de triângulos,
        a classe deve possuir métodos de leitura de dados, de exibição de das 
        informações e um método para calcular sua Área. Crie uma classe para testar.
        */

namespace attTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo(20,30);

            Console.WriteLine(
                triangulo.calculo(triangulo.getAltura(), triangulo.getBase())
            );
        }
    }
}
