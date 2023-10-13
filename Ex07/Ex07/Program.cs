namespace Ex07;

class Program
{
    static void Main()
    {
        int n2= 0;
        int n1 = 0;

        for (int i = 1; i <= 20; i++)
        {
            Console.Write("Digite o primeiro número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                n2++;
            }
            else
            {
                n1++;
            }
        }

        Console.WriteLine("Quantidade de números pares: " + n2);
        Console.WriteLine("Quantidade de números ímpares: " + n1);
    }
}