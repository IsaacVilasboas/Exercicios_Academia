namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int joao, zeca, branco;
            joao = 0;
            zeca = 0;
            branco = 0;

            Console.WriteLine("***ELEIÇÕES***");
            while (true)
            {
                Console.WriteLine("Para quem vai o seu voto ? João, Zeca, ou Branco");
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
            }
            Console.WriteLine("Joao teve " + joao + " votos");
            Console.WriteLine("Zeca teve " + zeca + " votos");
            Console.WriteLine(branco + " votos em branco");
        }
    }
}