namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            int tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}