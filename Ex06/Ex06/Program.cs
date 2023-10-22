namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[10];

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                
            }
            for (int i = 9; i >= 0; i--)
            {
                Console.Write(v[i]);
            }
        }
    }
}