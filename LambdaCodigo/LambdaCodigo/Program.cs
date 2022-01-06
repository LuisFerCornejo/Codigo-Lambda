using System;
using System.Linq;

namespace LambdaCodigo
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Console.WriteLine("El resultado es: "+square(10));
            Console.WriteLine("");
            Console.WriteLine("");



            static int Metodo (int x)
            {
                return x * x;
            }
            Console.WriteLine("El resultado del cuadrado es: " + Metodo(5));
            Console.WriteLine("");
            Console.WriteLine("");



            Func<int, int, int> resta = (x,y) => x - y;
            Console.WriteLine("El resultado de la resta es: " + resta(8, 4));
            Console.WriteLine("");
            Console.WriteLine("");


            int[] arraylistanumeros = { 2, 4, 6, 8, 10, 12, 20 };
            var listanumeroscuadrado = arraylistanumeros.Select(x => x * x);
            Console.WriteLine("El resultado del cuadrado de cada numero es: ");
            foreach (int x in listanumeroscuadrado)
                Console.WriteLine(x);
        }
    }
}
