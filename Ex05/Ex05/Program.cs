namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[5];


            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }

            int menor = v[0];
            int posição = 0;

            for (int i = 1; i < v.Length; i++) {

                if (v[i] < menor)
                {
                    menor = v[i];
                    posição = i;
                }
            }
            Console.WriteLine("O menor valor é " + menor + " e está na posição " + posição);

        }
    } 
}

