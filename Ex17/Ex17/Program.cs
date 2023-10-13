namespace Ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] m = new int[10,10];

            int valor = 0;
            int max = 0;
            int linha = 0;
            int coluna = 0;

            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    m[i, j] = random.Next(1,101);
                }
            }
            for(int i = 0; i < 10; i++)
            {
                for (int j = 0;j < 10; j++)
                {
                    Console.Write(m[i,j] + "   ");
                }
                Console.WriteLine();
            }
            for (int i = 0;i < 10; i++)
            {
                for(int j = 0;j < 10; j++)
                {
                    valor = m[i,j];

                    if (valor > max)
                    {
                        max = valor;
                        linha = i;
                        coluna = j;
                    } 
                }
            }
            int menorLinha = m[linha, 0];
            for ( int j = 0; j < 10; j++)
            {
                if (m[linha, j] < menorLinha) { 
                    {
                      menorLinha = m[linha, j];
                    }
                }
            }
            Console.WriteLine("Maior " + max);
            Console.WriteLine("Menor " + menorLinha);
            Console.WriteLine("Linha " + linha);
            Console.WriteLine("Coluna " + coluna);
        }
    }
}
