namespace Atv5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estúdio p = new Estúdio();
            Console.WriteLine("Qual o nome do Estúdio");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Qual o ano da Fundação:");
            p.AnoFundação = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o Páis de Origem");
            p.PaísOrigem = Console.ReadLine();
            Console.WriteLine("Quantos Jogos foram produzidos?");
            p.NúmeroJogos = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome: "  + p.Nome);
            Console.WriteLine("Ano da Fundação " + p.AnoFundação);
            Console.WriteLine("País Origem: " + p.PaísOrigem);
            Console.WriteLine("Número de Jogos: " + p.NúmeroJogos);
        }
    }
}