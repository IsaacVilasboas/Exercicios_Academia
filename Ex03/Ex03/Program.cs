namespace Ex03

{
    internal class Program
    {
        // Função para verificar se um número é primo
        static bool EhPrimo(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
        static void Main()
        {
            int[] v = new int[5];

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("posições dos números primos:");

            for (int i = 0; i < v.Length; i++)
            {
                if (EhPrimo(v[i])) //função EhPrimo verifica para saber se o numero é inteiro
                {
                    Console.WriteLine(v[i]);
                }
            }
        }
    }
}
