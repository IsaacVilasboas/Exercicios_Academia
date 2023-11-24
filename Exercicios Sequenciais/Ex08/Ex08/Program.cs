namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int C, F;
            Console.WriteLine("Qual a temperatura em graus Celius: ");
            C = int.Parse(Console.ReadLine());

            F = (9 * C + 160) / 5;
            Console.WriteLine("Graus em F°: " + F);
        }
    }
}