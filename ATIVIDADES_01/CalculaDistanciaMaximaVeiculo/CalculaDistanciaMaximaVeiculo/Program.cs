using System;
using System.Globalization;
namespace CalculaDistanciaMaximaVeiculo
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("****CALCULA DISTÂNCIA MÁXIMA DO SEU VEÍCULO****");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Informe a quantidade de litros do abastecimento:");
            decimal QuantidadeLitrosAbastecido = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe a média de consumo do seu veículo:");
            decimal ConsumoMedioVeiculo = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            decimal DistanciaMaxima = ConsumoMedioVeiculo * QuantidadeLitrosAbastecido;
            Console.WriteLine("Com "+ QuantidadeLitrosAbastecido.ToString("F2", CultureInfo.InvariantCulture)+" litros, você irá percorrer aproximadamente "+ DistanciaMaxima.ToString("F2", CultureInfo.InvariantCulture)+" quilômetros.");

        }
    }
}