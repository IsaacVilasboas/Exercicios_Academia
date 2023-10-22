namespace Ex20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int pares = 0;
            
            for ( int i = 1; i <= 500;i++)
            {   cont += 1;
                if (cont % 2 == 0)
                {
                    pares += cont;
                }
            }
            Console.WriteLine("A somatoria dos números são : " + pares);
        }
    }
}