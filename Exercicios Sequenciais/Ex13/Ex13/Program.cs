namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minimo, valorBicicleta, vendasBicicleta, comprasBicicleta;
            double comissão, salario, salariototal;

            Console.WriteLine("Qual o salário do vendendor? ");
            minimo = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o preço da bicicleta ?");
            valorBicicleta = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas bicicletas foram vendidas ?");
            vendasBicicleta = int.Parse(Console.ReadLine());



            comprasBicicleta = valorBicicleta / 2;
            salario = minimo * 2;
            comissão = (comprasBicicleta * vendasBicicleta) * 15 / 100;
            salariototal = salario + comissão;

            Console.WriteLine(salariototal);
        }
    }
}
