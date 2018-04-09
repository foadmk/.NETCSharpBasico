using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Exemplo de Struct, Enum e ArrayList / List
namespace Exercicio3
{
    enum Tipo
    {
        ISOCELES,
        EQUILATERO,
        RETANGULO
    };
    struct Triangulo
    {
        public Tipo tipo;
        public double tamAltura;
        public double tamBase;
        public static Random rand = new Random(); //evita a criação de várias instancias do Random, quando elas são criadas em um tempo muito pequeno, o classe não randomiza adequadamente

        public void init()
        {            
            tipo = (Tipo)rand.Next(0, 3);  // Gera um número aletorio: 0, 1 ou 2
            tamAltura = rand.NextDouble() * 10;
            tamBase = rand.NextDouble() * 10;
        }

        public void show()
        {
            Console.WriteLine($"Triangulo {tipo} base {tamBase} altura {tamAltura}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio Triangulo");

            //List<Triangulo> triangulos = new List<Triangulo>();  //Lista com genero também funcionam
            ArrayList triangulos = new ArrayList();

            for(int i=0; i<5; i++)
            { 
                Triangulo x = new Triangulo();
                x.init();
                triangulos.Add(x);
            }

            foreach (Triangulo t in triangulos)
            {
                t.show();
            }
        }
    }
}
