namespace Ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int f1, f2, f3,nao;
                f1 = 0;
                f2 = 0;
                f3 = 0;
                nao = 0;

                for (int i = 1; i <= 30; i++)
                {
                    Console.WriteLine("Quantos filhos tem as pessoas");
                    int filhos = int.Parse(Console.ReadLine());
                    if (filhos > 0 && filhos <= 3)
                    {
                        f1 += 1;
                    }
                    else if (filhos > 3 && filhos <= 7)
                    {
                        f2 += 1;
                    }
                    else if (filhos >= 8)
                    {
                        f3 += 1;
                    }
                    else if (filhos == 0)
                    {
                        nao += 1;
                    }
                }
                 Console.WriteLine("Pessoas com 1 a 3 filhos " + f1 );
                 Console.WriteLine("Pessoas com 4 a 7 filhos " + f2 );
                 Console.WriteLine("Pessoas com mais de 8 filhos" + f3);
                 Console.WriteLine("Pessoas sem filhos " + nao); 
            }
        }
    }
}