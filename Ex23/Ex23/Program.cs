namespace Ex23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (true) { 
            Console.WriteLine("digite um numero menor igual a 50");
            n = int.Parse(Console.ReadLine());
                n = n * 3;
                Console.WriteLine("N * 3 = " + n );
                if (n < 250 )
                {
                    n = n * 3;
                    Console.WriteLine("N * 3 * 3 = " + n);
                    if( n < 250)
                    {
                        n = n* 3;
                        Console.WriteLine("N * 3 * 3 * 3 = " + n);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Valor utrapassou a 250");
                        Console.WriteLine("Tente novamente");
                    }
                }
                else
                {
                    Console.WriteLine("Valor utrapassou a 250");
                    Console.WriteLine("Tente novamente");
                }
            }
            Console.WriteLine(n);
        }
    }
}