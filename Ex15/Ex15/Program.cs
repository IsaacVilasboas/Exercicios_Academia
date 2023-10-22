using System.ComponentModel.Design;

namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Digite um numero inteiro");
                int n = int.Parse(Console.ReadLine());
                if (n % 1 == 0)
                {
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("O número " + n + " é par");
                    }
                    else if (n % 2 != 0)
                    {
                        Console.WriteLine("O número " + n + " é ímpar");
                    }
                    else
                    {
                        Console.WriteLine("Número errado, tente novamente!");
                    }
                }
                Console.WriteLine("Deseja repetir ?[s/n]");
            } while (Console.ReadLine().ToLower() == "s");
        }
    }
}
