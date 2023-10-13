namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("O número informado é Par");
            }
            else
            {
                Console.WriteLine("Número informado é impar");
            }
        }
    }
}