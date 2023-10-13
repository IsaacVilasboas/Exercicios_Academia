namespace Ex25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um número: ");
            double bs = double.Parse(Console.ReadLine());
            Console.WriteLine("digite um número para ser o expoente: ");
            int exp = int.Parse(Console.ReadLine());

            bs = Math.Pow(bs, exp);
            Console.WriteLine(bs);
        }
    }
}