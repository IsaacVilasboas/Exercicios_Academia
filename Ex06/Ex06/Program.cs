namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            int valor = 0;
            int maiorvalor = int.MinValue;
            int[,] m = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    m[i, j] = random.Next(10);
                }
            }
            for(int i  = 0; i < 4; ++i)
            {
                for(int j = 0;j < 4; j++)
                {
                    Console.Write(m[i,j] + "  " );
                }
            Console.WriteLine(i);
            }
            for (int i = 0;i < 4; i++)
            {
                for(int j = 0;j < 4; j++)
                {
                    valor = m[i, j];
                    if (valor > maiorvalor)
                    {
                        maiorvalor = valor;
                    }
                }
            }
            Console.WriteLine(maiorvalor);
        }
    }
}