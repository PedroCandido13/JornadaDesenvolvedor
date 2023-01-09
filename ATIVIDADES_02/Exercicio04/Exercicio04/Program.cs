using System;
using System.Data;
using System.Globalization;
namespace Exercicio04
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("***CALCULA E EXIBE LUCRO POR PRODUTO***");
            Console.WriteLine("***************************************");
            int quantosProdutos;
            Console.WriteLine("De quantos produtos você quer saber o lucro?");
            quantosProdutos = int.Parse(Console.ReadLine());
            string[] Produtos = new string[quantosProdutos];
            double[] lucro = new double[quantosProdutos];
            Console.Clear();
            //Entrada  e processamento de dados
            for (int linha = 0; linha < quantosProdutos; linha++)
            {
                double Quantidade = 0, PrecoCompra = 0, PrecoVenda = 0;
                Console.WriteLine("Digite o nome do " + (linha + 1) + "º produto:");
                Produtos[linha] = Console.ReadLine();
                Console.WriteLine("Informe a quantidade vendida deste produto:");
                Quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Informe o preço de compra do " + Produtos[linha] + ":");
                PrecoCompra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Informe o preço de venda do " + Produtos[linha] + ":");
                PrecoVenda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Clear();
                lucro[linha] = (PrecoVenda - PrecoCompra) * Quantidade;
            }
            //Exibindo o resultado
            for (int linha = 0; linha < quantosProdutos; linha++)
            {
                Console.WriteLine("O lucro do " + Produtos[linha] + " é de: R$ " + lucro[linha].ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }

}