namespace Atv6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro p = new Carro();
            Carro p2 = new Carro();

            Console.WriteLine("Qual a marca do carro?");
            p.marca = Console.ReadLine();
            Console.WriteLine("Qual o modelo ?");
            p.modelo = Console.ReadLine();
            Console.WriteLine("Qual o ano ?");
            p.AnoFabricação = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a marca do 2° carro?");
            p2.marca = Console.ReadLine();
            Console.WriteLine("Qual o modelo do 2° carro ?");
            p2.modelo = Console.ReadLine();
            Console.WriteLine("Qual o ano do 2° carro ?");
            p2.AnoFabricação = int.Parse(Console.ReadLine());

            Console.WriteLine("Marca 1° carro: " + p.marca);
            Console.WriteLine("Modelo 1° carro: " + p.modelo);
            Console.WriteLine("Ano de Fabricação 1° carro " + p.AnoFabricação);
            Console.WriteLine("Marca 2° carro: " + p2.marca);
            Console.WriteLine("Modelo 2° carro: " + p2.modelo);
            Console.WriteLine("Ano de Fabricação 2° carro " + p2.AnoFabricação);

        }
    }
}