namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int indice = 0;
            double[,] m = new double[3, 3];
            double[,] m2 = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m[i,j] = double.Parse(Console.ReadLine());
                }
            }
            for (int i = 0;i < 3; i++)
            {
                for(int j = 0;j < 3; j++)
                {
                    indice = i + j;

                    if (indice != 0)
                    {
                        m2[i,j] = m[i,j] / indice;
                    }
                    else
                    { //ele recebe o valor de 0 pois o índice está no valor de 0, então todo número dividido por 0 = 0
                        m2[i, j] = 0;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0;i<3; i++)
            {
                for( int j = 0;j<3; j++)
                {
                    Console.Write(m2[i,j] + "  ");
                }
            }
            Console.WriteLine();
        }
    }
}
