namespace Atv13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Drive");
            Console.WriteLine("Carro:");
            Carro carro = new Carro("4","Ford", "Focus");
            carro.Dirigir();

            Console.WriteLine();

            Console.WriteLine("Moto: ");
            Moto moto = new Moto("1000", "Yamaha", "Z1");
            moto.Dirigir();
            
            Console.WriteLine("Muito Obrigado!!");

        }
    }
}