using System;
using System.Globalization;

namespace CalculaConsumoDeCarro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("****CALCULE O CONSUMO DO SEU VEÍCULO****");
            Console.WriteLine("****************************************");
            Console.WriteLine("Informe os quilômetros rodados desde o último abastecimento:");
            decimal KmRodados = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira a quantidade de litros que foram necessários para encher o seu tanque:");
            decimal LitrosAbastecido = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            decimal consumo = KmRodados / LitrosAbastecido;
            Console.WriteLine("O seu veículo está fazendo em média " + consumo.ToString("F2", CultureInfo.InvariantCulture) + " quilômetros por litro.");
        }
    }
}