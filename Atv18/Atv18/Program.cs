namespace Atv18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> veiculos = new List<Veiculo>();

            Veiculo veiculo = new Veiculo("Fiat Uno", 2009);
            Carro carro = new Carro("Ford Focus", 2014, 4);
            Carro carro2 = new Carro("Fiat Palio", 2007, 4);
            Moto moto = new Moto("Honda CBR", 2018, 1000);
            Moto moto2 = new Moto("Yamaha MT 09", 2023, 900);
            
            veiculos.Add(veiculo);
            veiculos.Add(carro);
            veiculos.Add(carro2);
            veiculos.Add(moto);
            veiculos.Add(moto2);
           
            foreach ( var automoveis in veiculos) 
            { 
                automoveis.Apresentar();
                Console.WriteLine();
            }
        }
    }
}