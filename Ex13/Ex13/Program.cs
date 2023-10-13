namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[100];
            int cont = 0;
            int cont2 = 0;
            int cont3 = 0;
            for (int i = 0; i < 100; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] < 0) {
                    break;
                }
            }
            for (int i = 0;i < 100; i++)
            {
                if (v[i] == 2) {
                    cont++;
                }
                if (v[i] == 4) { 
                    cont2++;
                }
                if (v[i] == 8)
                {
                    cont3++;
                }
            }
            Console.WriteLine("O número 2 aparece " + cont + "x");
            Console.WriteLine("O número 4 aparece " + cont2 + "x");
            Console.WriteLine("O número 8 aparece " + cont3 + "x");
        }
    }
}