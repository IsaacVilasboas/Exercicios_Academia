namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[5];
            for (int i = 0; i < 5; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 4;i >= 0; i--)
            {
                Console.WriteLine(v[i]);
            }
        }
    }
}