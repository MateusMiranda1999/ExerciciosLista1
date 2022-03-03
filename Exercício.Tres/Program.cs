using System;

namespace Exercício.Tres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantida de KM rodada: ");
            decimal.TryParse(Console.ReadLine(), out decimal kmPercorrido);

            Console.WriteLine("Informe a quantida de Combustivel: ");
            decimal.TryParse(Console.ReadLine(), out decimal LitrosGastos);

            Console.WriteLine($"Sua média foi de {kmPercorrido / LitrosGastos}");
            Console.ReadLine();

        }
    }
}
