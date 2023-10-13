namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[5];
            Console.WriteLine("Digite um número 0, 1 ou 2: ");
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("Programa encerrado");
            }
            if (n == 1)
            {
                for (int i = 0; i < 5; i++)
                {
                    v[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0;i < 5; i++) {
                    Console.WriteLine(v[i]);
                }
            }
            if (n == 2) { 
                for (int i = 0;i < 5 ; i++)
                {
                    v[i] = int.Parse(Console.ReadLine()) ;
                }
                for(int i = 4; i >= 0 ; i--)
                {
                    Console.WriteLine(v[i]);
                }
            }
        }
    }
}