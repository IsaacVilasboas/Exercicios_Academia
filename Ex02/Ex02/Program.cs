namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maior, n;
            maior = 0;
            for (int i = 0; i < 10; i++)
            {
                n = int.Parse(Console.ReadLine());
                
                if (n >= maior)
                {
                    maior = n;
                   
                }
            }
            Console.WriteLine(maior);
        }
    }
}