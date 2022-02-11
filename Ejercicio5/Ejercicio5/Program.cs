using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un valor para X: ");
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa un valor para Y: ");
            int Y = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa un valor para N: ");
            double N = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa un valor para M: ");
            double M = double.Parse(Console.ReadLine());

            Console.WriteLine("\nValor de X: " + X +
                "\nValor de Y: " + Y +
                "\nValor de N: " + N +
                "\nValor de M: " + M);

            // SUMA
            int suma = X + Y;

            double suma1 = N + M;

            double suma2 = X + N;

            double suma3 = X + Y + N + M;

            Console.WriteLine(
                "\nSuma de x+y: " + suma +
                "\nSuma de n+m: " + suma1 +
                "\nSuma de x+n: " + suma2 +
                "\nSuma de todas las variables: " + suma3 +
                "\n");

            // DIFERENCIA
            int resta = X - Y;

            double resta1 = N - M;

            Console.WriteLine(
                "Resta de x-y: " + resta +
                "\nResta de n-m: " + resta1 +
                "\n");

            // PRODUCTO
            int producto = X * Y;

            double producto1 = N * M;

            double producto2 = X * Y * N * M;

            Console.WriteLine(
                "Producto de x.y: " + producto +
                "\nProducto de n.m: " + producto1 +
                "\nProducto de todas las variables: " + producto2 +
                "\n");

            // COCIENTE
            int cociente = X / Y;

            double cociente1 = N / M;

            double cociente2 = Y / M;

            Console.WriteLine(
                "Cociente de x/y: " + cociente +
                "\nCociente de n/m: " + cociente1 +
                "\nCociente de y/m: " + cociente2 +
                "\n");

            // RESTO
            int resto = X % Y;

            double resto1 = N % M;

            double resto3 = Y % M;

            Console.WriteLine(
                "Resto de x%y: " + resto +
                "\nResto de n%m: " + resto1 +
                "\nResto de y%m: " + resto3 +
                "\n");

            // DOBLE PRODUCTO
            int dobleX = X * 2;

            int dobleY = Y * 2;

            double dobleN = N * 2;

            double dobleM = M * 2;

            Console.WriteLine(
                "El doble de x es: " + dobleX +
                "\nEl doble de y es: " + dobleY +
                "\nEl doble de n es: " + dobleN +
                "\nEl doble de m es: " + dobleM);
        }
    }
}
