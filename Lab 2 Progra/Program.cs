using System;

namespace VariablesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            int entero;
            double decimalNum;
            string texto;
            bool booleano;

            // Pedir valores por teclado
            Console.Write("Introduce un número entero: ");
            entero = int.Parse(Console.ReadLine());

            Console.Write("Introduce un número decimal: ");
            decimalNum = double.Parse(Console.ReadLine());

            Console.Write("Introduce un texto: ");
            texto = Console.ReadLine();

            Console.Write("Introduce un valor booleano (true/false): ");
            booleano = bool.Parse(Console.ReadLine());

            // Mostrar valores en consola
            Console.WriteLine($"Número entero: {entero}");
            Console.WriteLine($"Número decimal: {decimalNum}");
            Console.WriteLine($"Texto: {texto}");
            Console.WriteLine($"Booleano: {booleano}");
        }
    }
}
