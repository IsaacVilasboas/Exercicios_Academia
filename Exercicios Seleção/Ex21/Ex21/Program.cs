namespace Ex21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione a unidade de medida de entrada:");
            Console.WriteLine("1. Metros");
            Console.WriteLine("2. Centímetros");
            Console.WriteLine("3. Polegadas");
            Console.WriteLine("4. Pés");

           
            int escolhaEntrada = int.Parse(Console.ReadLine());

            Console.WriteLine("Selecione a unidade de medida de saída:");
            Console.WriteLine("1. Metros");
            Console.WriteLine("2. Centímetros");
            Console.WriteLine("3. Polegadas");
            Console.WriteLine("4. Pés");

            
            int escolhaSaida = int.Parse(Console.ReadLine());

            
            Console.Write("Digite o valor de entrada: ");
            double valorEntrada = double.Parse(Console.ReadLine());

            double valorSaida = 0.0;

            
            switch (escolhaEntrada)
            {
                case 1: 
                    switch (escolhaSaida)
                    {
                        case 1: 
                            valorSaida = valorEntrada;
                            break;
                        case 2: 
                            valorSaida = valorEntrada * 100;
                            break;
                        case 3: 
                            valorSaida = valorEntrada * 39.37;
                            break;
                        case 4: 
                            valorSaida = valorEntrada * 3.281;
                            break;
                        default:
                            Console.WriteLine("Unidade de saída inválida.");
                            return;
                    }
                    break;
                case 2: 
                    switch (escolhaSaida)
                    {
                        case 1: 
                            valorSaida = valorEntrada / 100;
                            break;
                        case 2:
                            valorSaida = valorEntrada;
                            break;
                        case 3: 
                            valorSaida = valorEntrada / 2.54;
                            break;
                        case 4: 
                            valorSaida = valorEntrada / 30.48;
                            break;
                        default:
                            Console.WriteLine("Unidade de saída inválida.");
                            return;
                    }
                    break;
                case 3: 
                    switch (escolhaSaida)
                    {
                        case 1: 
                            valorSaida = valorEntrada / 39.37;
                            break;
                        case 2: 
                            valorSaida = valorEntrada * 2.54;
                            break;
                        case 3: 
                            valorSaida = valorEntrada;
                            break;
                        case 4: 
                            valorSaida = valorEntrada / 12;
                            break;
                        default:
                            Console.WriteLine("Unidade de saída inválida.");
                            return;
                    }
                    break;
                case 4: 
                    switch (escolhaSaida)
                    {
                        case 1: 
                            valorSaida = valorEntrada / 3.281;
                            break;
                        case 2: 
                            valorSaida = valorEntrada * 30.48;
                            break;
                        case 3: 
                            valorSaida = valorEntrada * 12;
                            break;
                        case 4: 
                            valorSaida = valorEntrada;
                            break;
                        default:
                            Console.WriteLine("Unidade de saída inválida.");
                            return;
                    }
                    break;
                default:
                    Console.WriteLine("Unidade de entrada inválida.");
                    return;
            }

            Console.WriteLine($"Valor de saída: {valorSaida} na unidade selecionada.");
        }
    }
}