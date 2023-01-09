using System;
using System.Globalization;

namespace ComissaoVendedor
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("****CALCULANDO SUA COMISSÃO + SALÁRIO****");
            Console.WriteLine("*****************************************");
            Console.WriteLine("Digite o seu nome:");
            string Nome = Console.ReadLine();
            Console.WriteLine("Informe o seu salário fixo:");
            double SalarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe em R$, a quantidade de vendas que você efetuou neste mês:");
            double TotalVendasMes = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double SalarioFinalComComissao = TotalVendasMes * 0.15 + SalarioFixo;
            Console.WriteLine("Vendedor "+Nome+", o seu salário final é de R$:"+SalarioFinalComComissao.ToString("F2", CultureInfo.InvariantCulture)+" reais.");
        }
    }
}