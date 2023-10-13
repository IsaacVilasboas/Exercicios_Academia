namespace Ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            double nota;
            double somanotas = 0;
            double maior =  double.MinValue;
            double menor = double.MaxValue;
            while (true)
            {
                Console.Write("Nota (ou -1 para encerrar): ");
                nota = double.Parse(Console.ReadLine());
                cont += 1;
                somanotas += nota;

                if (nota == -1)
                {
                    break;
                }

                if (nota > maior)
                {
                    maior = nota;
                }

                if (nota < menor)
                {
                    menor = nota;
                }
            } 
            double media = somanotas / cont;
            Console.WriteLine("A maior nota é " + maior);
            Console.WriteLine("A menor nota é " + menor);
            Console.WriteLine("A media da turma é " + media);
            Console.WriteLine("A quantidade de alunos na sala é " + cont);
        }
    }
}