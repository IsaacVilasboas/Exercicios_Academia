namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] v = new double[30];
            int casa = 0;

            for (int i = 0; i < 30; i++)
            {
                v[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0;i < 30; i++)
            {
              
                if (v[i] < 0) {
                    casa = i;
                    Console.Write((casa + 1)+" ");
                }
            }
        }
    }
}