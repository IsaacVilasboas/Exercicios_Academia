namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura, @base;
            float area;
            altura = int.Parse(Console.ReadLine());
            @base = int.Parse(Console.ReadLine());

            if (altura != 0 && @base != 0)
            {
                area = (altura * @base) / 2;
                Console.WriteLine(area);

            }
            else
            {
                Console.WriteLine("Altura ou Base são iguais a 0");
            }
        }
    }
}