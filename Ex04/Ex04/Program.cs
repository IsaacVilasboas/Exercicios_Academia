namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[5, 5];
            int pares = 0;
            int impares = 0;
            int positivos = 0;
            int negativos = 0;
            int zeros = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 5; ++i)
            {
                for(int j = 0; ++j < 5; ++j)
                {
                    if(m[i,j] % 2 == 0)
                    {  
                        pares++;
                    }
                    if (m[i,j] % 2 != 0)
                    {
                        impares++;
                    }
                }
            }
            for (int i = 0;i < 5; ++i)
            {
                for( int j = 0;j < 5; ++j)
                {
                    if (m[i,j] > 0)
                    {
                        positivos++;
                    }
                    if (m[i,j] < 0)
                    {
                        negativos++;
                    }
                    if (m[i,j] == 0)
                    {
                        zeros++;
                    } 
                }
            }
            Console.WriteLine(pares + " pares");
            Console.WriteLine(impares + " ímpares");
            Console.WriteLine(positivos + " positivos");
            Console.WriteLine(negativos + " negativos");
            Console.WriteLine(zeros + " zeros");
        }
    }
}