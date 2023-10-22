namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int elementos = 10;
            int[] v = new int[elementos];
            int[] v2 = new int[elementos];
            int[] v3 = new int[elementos];

            for (int i = 0; i < elementos; i++)
            {

                v[i] = int.Parse(Console.ReadLine());

                v2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < elementos; i++)
            {
                v3[i] = v[i] * v2[i];
                Console.WriteLine(v3[i]);
            }
        }
    }
}