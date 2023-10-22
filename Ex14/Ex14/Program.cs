namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, salario;
            string nome;

            while (true)
            {
                Console.WriteLine("Qual é o seu nome ?");
                nome = Console.ReadLine();
                if (nome == "" || nome == " ")
                {
                    Console.WriteLine("Nome invalido");
                    break;
                }
                else if (true)
                {
                    Console.WriteLine("Qual a sua idade ?");
                    idade = int.Parse(Console.ReadLine());
                    if (idade <= 0)
                    {
                        Console.WriteLine("Idade invalida");
                        break;
                    }
                    else if (idade > 0)
                    {
                        Console.WriteLine(idade);
                        Console.WriteLine("Qual é o seu salario?");
                        salario = int.Parse(Console.ReadLine());
                        if (salario <= 0)
                        {
                            Console.WriteLine("Valor incorreto");
                            break;
                        }
                        else if (salario > 0)
                        {
                            Console.WriteLine(salario);
                        }
                    }
                    {

                    }
                }

            }
        }
    }
}