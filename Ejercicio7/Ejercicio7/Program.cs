using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un valor: ");
            int A = Convert.ToInt32(Console.ReadLine());

            string evaluar = A % 2 == 0 ? (A + " es un numero par") : (A + " es un numero impar");

            Console.WriteLine("\n" + evaluar);
        }
    }
}
