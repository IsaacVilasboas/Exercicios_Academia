namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[10];
            int pares = 0;
            int impares = 0;
            for (int i = 0; i < 10; i++) {

                v[i] = int.Parse(Console.ReadLine());
            }
        
            for (int i = 0;i < 10; i++)
            {
                if (v[i] % 2 == 0) 
                {
                    Console.Write(v[i]);
                }
            }
            Console.Write(' ');
            for (int i = 0;i < 10; i++) {
                
                if (v[i] % 2 != 0)
                {
                    Console.Write(v[i]);
                }
            }
        }
    }
}