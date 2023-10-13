namespace Ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] m = new int[3, 4];
            int[,] n = new int[4, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    m[i,j] = random.Next(10);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(m[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int j = 0; j < 4; j++)
            {
                for(int i = 0;i < 3; i++)
                {
                    n[j,i] = m[i,j];
                }
            }
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(n[j,i] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}