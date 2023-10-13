namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] m = new int[4, 4];
            int[,] m2 = new int[4, 4];
            int[,] r = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    m[i, j] = random.Next(10);
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    m2[i, j] = random.Next(10);
                }
            }
            for(int i = 0;i < 4; i++)
            {
                for(int j = 0;j < 4; j++)
                {
                    r[i, j] = m[i,j] + m2[i, j];
                }
            }
            for(int i = 0;i < 4 ; i++)
            {
                for( int j = 0;j< 4 ; j++)
                {
                    Console.Write(r[i,j] + "  " );
                }
                Console.WriteLine();
            }
            
        }
    }
}