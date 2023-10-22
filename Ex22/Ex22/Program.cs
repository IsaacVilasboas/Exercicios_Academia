namespace Ex22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1 = 2;
            double p2 = 1;
            double p3 = 2;
            double p4 = 4;
            double media = 0;
            while (true)
            {
                Console.WriteLine("Qual a primeira nota do aluno? ");
                double n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual a segunda nota do aluno? ");
                double n2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual a terceira nota do aluno? ");
                double n3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual a quarta nota do aluno? ");
                double n4 = double.Parse(Console.ReadLine());

                media = (n1 * p1 + n2 * p2 + n3 * p3 + n4 * p4) / (p1 + p2 + p3 + p4);
                if (media >= 7.0)
                {
                    Console.WriteLine("Aprovado!! Com media: " + media.ToString("F1"));
                    break;
                }
                else
                {
                    Console.WriteLine("Reprovado! Media: " + media.ToString("F1"));
                    break;
                }  
            }
        }
    }
}