namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 litro = 3m²
            // 1 lata tem 18l
            // 1 lata custa 80$
            Console.WriteLine("Qual o tamanho em metros quadrados ?");
            double metros = double.Parse(Console.ReadLine());
            double litros = metros / 3.0;
            double latas = litros / 18.0;
            double valor = latas * 80.0;
            Console.WriteLine(valor.ToString("F2"));
            Console.WriteLine(latas.ToString("F0"));



        }
    }
}
