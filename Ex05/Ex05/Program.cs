namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] m = new double[2, 5];
            double[,] m2 = new double[2, 5];
            double[,] m3 = new double[2, 5];
            
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("Digite o valor da linha " + (i+1));
                    m[i,j] = double.Parse(Console.ReadLine());
                }
            }
            for (int i = 0;i < 2; i++)
            {
                for(int j = 0;j < 5; j++)
                {
                    Console.WriteLine("Digite o valor da linha " + (i + 1));
                    m2[i,j] = double.Parse(Console.ReadLine());
                }
            }
            for(int i = 0;i < 2; i++)
            {
                for(int j = 0; j<5; j++)
                {
                    m3[i,j] = m2[i,j] + m[i,j];
                }
            }
            Console.WriteLine();
            for(int i = 0; i < 2; i++)
            {
                for( int j = 0; j < 5; j++)
                {
                    Console.Write("[ " + m3[i,j]+" ]");
                }
              Console.WriteLine(i);    
            }
        }
    }
}