namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu código?");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a sua jornada de horas trabalhada ?");
            int horas = int.Parse(Console.ReadLine());
            int salario = horas * 10;
            if (horas > 50) { 
                int extra = horas - 50;
                    extra = extra * 20;
                Console.WriteLine("O seu salário extra é: " + extra);
            }
            Console.WriteLine("O seu salário é:" +salario);
        }
    }
}