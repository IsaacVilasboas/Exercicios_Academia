namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int joao, zeca, branco, Nulos, total;
            joao = 0;
            zeca = 0;
            branco = 0;
            Nulos = 0;

            Console.WriteLine("***ELEIÇÕES***");
            while (true)
            {
                Console.WriteLine("Para quem vai o seu voto ? João, Zeca, Branco, ou Nulos");
                string voto = Console.ReadLine(); // a resposta vai para a variavel dos candidatos
                if (voto == "nao")
                {
                    break;

                }
                else if (voto == "joao")
                {
                    joao += 1;
                }
                else if (voto == "zeca")
                {
                    zeca += 1;
                }
                else if (voto == "branco")
                {
                    branco += 1;
                }
                else if (voto == "nulo")
                {
                    Nulos += 1;
                }
                }
            if (joao > zeca)
            {
            Console.WriteLine("Joao é o vencedor");
            }
            else
            {
            Console.WriteLine("Zeca é o vencedor");
            }
            total = joao + zeca + branco + Nulos;
            Console.WriteLine("Joao teve " + joao + " votos");
            Console.WriteLine("Zeca teve " + zeca + " votos");
            Console.WriteLine(branco + " votos em branco");
            Console.WriteLine(Nulos + " votos nulos");
            Console.WriteLine("O total de votos foram : " + total);
        }
    }
}