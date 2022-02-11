using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 1;
            int B = 2;
            int C = 3;
            int D = 4;
            int auxi = B;

            Console.WriteLine("Valores iniciales: ");
            Console.WriteLine("A = " + A +
                "\nB = " + B +
                "\nC = " + C +
                "\nD = " + D);

            B = C; //3
            C = A; //1           
            A = D; //4
            D = auxi; //2

            Console.WriteLine("\nValores finales: ");
            Console.WriteLine("A = " + A +
                "\nB = " + B +
                "\nC = " + C +
                "\nD = " + D);
        }
    }
}
