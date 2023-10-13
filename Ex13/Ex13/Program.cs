namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int idade;
            idade = 0;
            while (true)
            {
                Console.WriteLine("Digite a sua idade :");
                idade  = int.Parse(Console.ReadLine());
                if (idade >= 0) {
                    Console.WriteLine("Idade valida");
                    break;
                }
                else if ( idade <= 0) {
                    Console.WriteLine("Idade invalida. Tente novamente ");
                } 
            }
            Console.WriteLine(idade);
        }
    }
}
