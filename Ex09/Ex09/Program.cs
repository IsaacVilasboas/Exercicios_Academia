namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[3, 3];
            Random random = new Random();

            Console.WriteLine("Digite um número;");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m[i, j] = random.Next(0, 6);
                }
            }
            bool numero = false;
            for (int i = 0;i < 3; i++)
            {
                for(int j = 0;j < 3; j++)
                {
                    if (m[i, j] == n)
                    {
                        numero = true;
                        break;
                    }
                }
            }
            if (numero)
            {
                Console.WriteLine("O número " + n + " existe na matriz");
            }
            else
            {
                Console.WriteLine("O número " + n + " não existe na matriz");
            }
        }
    }
}