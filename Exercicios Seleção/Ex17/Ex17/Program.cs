namespace Ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeiro lado ?");
            int lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo lado?");
            int lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Terceiro lado ?");
            int lado3 = int.Parse(Console.ReadLine());

            int soma = lado1 + lado3;
            if (lado1 <= lado3 && lado3 < soma) {
                Console.WriteLine("triangulo feito");
                if (lado1 == lado3 && lado3 == lado2) {
                    Console.WriteLine("temos um triangulo equilátero");
                }
                else if (lado1 == lado3 && lado3 != lado2) {
                    Console.WriteLine("temos um triangulo isoceles");
                }
                else if (lado1 != lado3 && lado1 != lado2)
                {
                    if (lado2 != lado3)
                    {
                        Console.WriteLine("temos um triangulo escaleno");
                    }
                }
            }
        }
    }
}