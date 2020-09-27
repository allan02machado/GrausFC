using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInserido;
            const double n1 = 32;
            const double n2 = 5;
            const double n3 = 9;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Converta °F em °C");
            Console.ResetColor();
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Digite o valor desejado: ");

            Console.Write("Grau Fahrenheit: ");
            valorInserido = Convert.ToDouble(Console.ReadLine());
            double resultado = (valorInserido - n1) * n2 / n3;
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{valorInserido} °F equivalem a {resultado:N2} °C");
            Console.ResetColor();
            }
    }
}
