namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alunos, avaliações, soma;
            soma = 0;
            Console.WriteLine("Quantos alunos tem na turma ?");
            alunos = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas avaliações teve ?");
            avaliações = int.Parse(Console.ReadLine());

            for (int i = 0; i < alunos; i++)
            {
                
                Console.WriteLine("Qual foi a primeira nota do aluno ?");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual foi a segunda nota do aluno? ");
                int n2 = int.Parse(Console.ReadLine());
                soma = (n1 + n2) / avaliações;
                Console.WriteLine(soma);
            }
        }
    }
}
