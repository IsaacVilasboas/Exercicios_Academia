namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] m = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    m[i, j] = random.Next(0,6);
                }
            }
            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 5; ++j)
                {
                    Console.Write(m[i, j] + "  ");
                }
                Console.WriteLine();
            }
            for (int i = 0;i < 5; i++)
            {
                if (m[i,i] == m[i, 4 - i])
                {
                    Console.WriteLine("Os mesmo elementos são :" + m[i,i] + " ");  
                }
            }
        }
    }
}