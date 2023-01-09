using System.Globalization;
namespace MediaDasNotasTurma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            decimal[] vetNotasAlunos;
            Console.WriteLine("Informe a quantidade de notas a serem lidas:");
            N = int.Parse(Console.ReadLine());
            Console.Clear();
            vetNotasAlunos= new decimal[N];
            //Entrada de dados:
            for (int linha = 0; linha < N; linha++) { 
                Console.WriteLine("Informe a "+(linha+1)+"ª nota:");
                vetNotasAlunos[linha] = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Clear();
            }
            //Cálculo de dados:
            decimal soma = 0;
            for (int linha = 0; linha<N; linha++) { 
                 soma += vetNotasAlunos[linha];     
            }
            decimal media = soma / N;
            Console.WriteLine("A média de nota da turma é de: "+media.ToString("F2", CultureInfo.InvariantCulture)+" pontos.");
        }
    }
}