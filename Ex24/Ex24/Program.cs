namespace Ex24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cont;
            for (int i = 15; i <= 200; i++)
            {
                //cont = i * i; essa seria uma forma mais facil de fazer.
                cont = Math.Pow(i, 2);
                Console.WriteLine(cont);
            }
        }   
    }
}