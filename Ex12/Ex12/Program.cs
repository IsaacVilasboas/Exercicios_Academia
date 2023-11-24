namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[,] m = new int[4, 3];
            int indice = 0;
            for (int i = 0;i < 4; i++)
            {
                for (int j = 0; j < 3; j++) 
                {
                    m[i,j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for(int j = 0;j < 3; j++)
                {
                    indice = i + j;
                    if (indice % 2 == 0 ) 
                    {
                        Console.Write(m[i,j] + "  ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
