using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


// Cria uma saida da seguinte forma
// 0
// 01
// 012
// 0123
// 01234

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício sobre Loop For:");

            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
