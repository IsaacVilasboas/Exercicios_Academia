namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] m = new int[3, 3];
            int[,] m2 = new int[3, 3];
            int[,] m3 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m[i, j] = random.Next(10);
                    Console.Write(m[i,j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m2[i, j] = random.Next(10);
                    Console.Write(m2[i,j] + "  ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m3[i, j] = m[i, j] - m2[i, j];
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(m3[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}