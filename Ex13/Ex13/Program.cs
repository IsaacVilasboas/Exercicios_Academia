namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int somap = 0;
            int somaS = 0;
            int[,] m = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    m[i, j] = random.Next(0, 6);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(m[i, j] + "  ");
                }
            Console.WriteLine();
            }
            Console.WriteLine();
            
            //diagonal primaria
            for (int i = 0; i < 5; i++)
            {
                    Console.Write(m[i,i] + "  ");
            }
            //somando o valor da diagonal primaria
            for(int i = 0; i < 5; i++)
            {
                somap = somap + m[i,i];
            }
            Console.WriteLine("= " + somap);
            
            //diagonal secundaria
            for (int i = m.GetLength(0) - 1; i >= 0; i--)
            {
                Console.Write(m[i, 4 - i] + "  ");
            }
            //somando o valor da diagonal secundaria
            for (int i = 0; i < 5; i++)
            {
               somaS = somaS +(m[i, 4 - i]);
            }
            Console.WriteLine("= " + somaS);
            while(true)
            {
                if(somap==somaS)
                {
                    Console.WriteLine("A soma das diagonais são iguais");
                    break;
                }
                else
                {
                    Console.WriteLine("A soma das diagonais tem valores diferentes");
                    break;
                }
            }
        }
    }
}
