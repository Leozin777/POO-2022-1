using System;
using attData.Entities;

/*
Escreva uma classe chamada Data, com os seguintes atributos inteiros: dia, mês e ano.
Permita a entrada destes atributos verificando a consistência dessas datas,
por exemplo não aceitar 31, caso o mês seja 02. Crie uma classe para testar.
*/

namespace attData
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data(31, 2, 2021);
        }
    }
}
