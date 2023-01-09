namespace ExibePessoaMaisVelha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int MaiorIdade=0;
            string NomeMaiorIdade = "";
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********EXIBINDO PESSOA MAIS VELHA**********");
            Console.WriteLine("***********************************************");
            int[] vetIdade;
            string[] vetNome;
            vetIdade= new int[10];
            vetNome= new string[10];
            //Entrada de dados
            for (int linha = 0; linha < 10; linha++) {
                Console.WriteLine("Insira o "+(linha+1)+"º nome:");
                vetNome[linha] = Console.ReadLine();
                Console.WriteLine("Insira a idade de " + vetNome[linha] +":" );
                vetIdade[linha] = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            //Verificação da pessoa mais velha
            for (int linha = 0; linha < 10; linha++) {
                if (vetIdade[linha] > MaiorIdade)
                {
                    MaiorIdade = vetIdade[linha];
                    NomeMaiorIdade = vetNome[linha];
                }
            }
            //Saída de dados
            Console.WriteLine("A pessoa com maior idade digitada foi: "+ NomeMaiorIdade+", com "+MaiorIdade+" anos.");
        }
    }
}