namespace Ex05;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número para calcular o fatorial: ");
        int n = int.Parse(Console.ReadLine());

        int f = 1; 

       
        if (n < 0)
        {
            Console.WriteLine("não é possivel calcular o fatorial de um número negativo");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }

            Console.WriteLine("O fatorial de " + n + " é " + f);
        }
    }
}