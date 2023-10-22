namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[20];
            int[] v2 = new int[20];

            for (int i = 0; i < 20; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0;i < 20; i++)
            {
                if (v[i] <= 0)
                {
                    v[i] = 2;
                }
            }
            for(int i = 0;i < 20 ; i++)
            {
                v2[i] = v[i];
                Console.Write(v2[i]);
            }
            
            
        }
    }
}