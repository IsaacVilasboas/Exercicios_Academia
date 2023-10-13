namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int HorasP1, HorasP2, ValorP1, ValorP2;

            Console.WriteLine("O primeiro professor deu quantas horas de aula ?");
            HorasP1 = int.Parse(Console.ReadLine());
            Console.WriteLine("O segundo professor deu quantas horas de aula ?");
            HorasP2 = int.Parse(Console.ReadLine());
            Console.WriteLine("O primeiro prefessor recebe quanto por cada hora ?");
            ValorP1 = int.Parse(Console.ReadLine());
            Console.WriteLine("O segundo prefessor recebe quanto por cada hora ?");
            ValorP2 = int.Parse(Console.ReadLine());

            ValorP1 = ValorP1 * HorasP1;
            ValorP2 = ValorP2 * HorasP2;

            if (ValorP1 > ValorP2)
            {
                Console.WriteLine("O primeiro professor tem o maior salário.");
            }
            else
            {
                Console.WriteLine("O segundo professor tem o maior salário");
            }
                
        }
    }
}
//4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
//Mostrar na tela qual dos professores tem o maior salário total.