namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            int cont;
            cont = 1;
            Console.WriteLine("Digite dois valores");
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            while (cont < y)
            {
                cont += 1;
                x = x * x;
                Console.WriteLine(x);
            }  
        }
    }

}