namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] m = new int[4,4];
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    m[i, j] = random.Next(10);
                    Console.Write(m[i,j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 3; i >= 0; i--)
            {
                for (int j = 3; j >= 0; j--)
                {
                    Console.Write(m[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}