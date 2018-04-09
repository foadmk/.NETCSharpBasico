using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Ordenar 3 números

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com 3 números");
            Console.Write("Primeiro Número: ");
            string s1 = Console.ReadLine();
            Console.Write("Segundo Número: ");
            string s2 = Console.ReadLine();
            Console.Write("Terceiro Número: ");
            string s3 = Console.ReadLine();

            int v1 = int.Parse(s1);
            int v2 = int.Parse(s2);
            int v3 = int.Parse(s3);

            if (v1 > v3)
            {
                int tmp = v1;
                v1 = v3;
                v3 = tmp;
            }
            if (v2 > v3)
            {
                int tmp = v2;
                v2 = v3;
                v3 = tmp;
            }
            if (v1 > v2)
            {
                int tmp = v1;
                v1 = v2;
                v2 = tmp;
            }

            Console.WriteLine($"Números ordenados: {v1} {v2} {v3}");

        }
    }
}
