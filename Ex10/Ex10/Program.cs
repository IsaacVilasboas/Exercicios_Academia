namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carro = new Carro();
            carro.Modelo = "BMW X6";
            carro.Ano = "2023";
            carro.Velocidade = 0;

            Console.WriteLine("O modelo: " + carro.Modelo);
            Console.WriteLine("O ano: " + carro.Ano);
            Console.WriteLine("A velocidade: " + carro.Velocidade);
            do
            {
                Console.WriteLine("Manual de comando");
                Console.WriteLine("Para Acelerar digite (1) Para Freiar (2) Para sair(0)");
                string rep = Console.ReadLine();
                switch (rep)
                {
                    case "1":
                        carro.Acelerar();
                        Console.WriteLine("Vrummm... A velocidade atual do carro é: " + carro.Velocidade + "km/h");
                        break;

                    case "2":
                        if (carro.Velocidade == 0)
                        {
                            Console.WriteLine("O carro está parado não tem como reduzir");

                        }
                        else
                        {
                            carro.Reduzir();
                            Console.WriteLine("Squirrr... A velocidade atual do carro é: " + carro.Velocidade + "km/h");      
                        }
                        break;
                    
                    case "0":
                        carro.Velocidade = 0;
                        Console.WriteLine("Finalizando o manual");
                        break;
                    
                    default: Console.WriteLine("Opção invalida");
                        break;
                }
            } while (carro.Velocidade > 0);

        }
    }
}