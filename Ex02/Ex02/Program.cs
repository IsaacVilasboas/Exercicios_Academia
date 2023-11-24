namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[3, 3];
            int somalinha = 0;
            int somacoluna = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine((j + 1) + " valor da linha " + i + " digite os números dela:");
                    m[i, j] = int .Parse(Console.ReadLine());
                }                
            }
            for (int i = 0;i < 3; i++)
            {
                somalinha = 0;
                for(int j = 0;j < 3; j++)
                {
                    somalinha += m[i, j];
                }
             Console.WriteLine("A soma dos valores da linha " + i + ": " + somalinha);
            }
            for(int i = 0;i <3; i++)
            {
                somacoluna = 0;
                for( int j = 0; j < 3; j++)
                {
                    somacoluna += m[i, j];
                }
                Console.WriteLine("A soma dos valores da coluna " + i + ": " + somacoluna);
            }
        }
    }
}