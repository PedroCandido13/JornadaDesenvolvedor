using System.Globalization;
namespace ExibirNumerosPositivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("**PROGRAMA QUE EXIBE OS NÚMEROS POSITIVOS**");
            Console.WriteLine("*******************************************");
            decimal[] SomaNumeros;
            SomaNumeros= new decimal[15];
            //Entrada de dados
            for (int linha = 0; linha < 15; linha++) {
                Console.WriteLine("Informe o " + (linha + 1) + "º número:");
                SomaNumeros[linha] = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Clear();
            }
            //Processamento e saída de dados
            int NumerosNegativos = 0;
            Console.WriteLine("Caso algum número positivo foi digitado, veja abaixo:");
            for (int linha = 0; linha < 15; linha++) {
               
                if (SomaNumeros[linha] < 0)
                {
                    NumerosNegativos += +1;
                }
                if (NumerosNegativos == 15)
                {
                    Console.WriteLine("Nenhum número positivo foi digitado!");
                }
                if (SomaNumeros[linha] > 0)
                {
                    Console.WriteLine(SomaNumeros[linha]);
                }
               
            }
        }
    }
}