namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v;
            int n = int.Parse(Console.ReadLine());
            v = new int[n];
            int impares = 0;
            int pares = 0;
            for (int i = 0; i < n; i++)
            {
                int valor = int.Parse(Console.ReadLine());
                v[i] = valor;  
            }
            for(int i = 0; i < n; i++)
            {
                if (v[i] % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }           
            Console.WriteLine("Teve " + impares + " números impares");
            Console.WriteLine("Teve " + pares + " números pares");
        }
    }
}
