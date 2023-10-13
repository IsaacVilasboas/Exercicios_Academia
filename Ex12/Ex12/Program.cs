namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[5];
            int numero = 0;
            int poss = 0;

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0;i < 5; i++)
            {
                if (v[i] == n)
                {
                    Console.WriteLine("O número informado está na  posição " + i + " e seu valor é: " + v[i]);
                }
                else
                {
                    Console.WriteLine("Número informado não está dentro do vetor");
                }
            }
        }
    }
}