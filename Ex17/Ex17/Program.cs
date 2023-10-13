namespace Ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int nm = 0;
            int idade30 = 0;
            int idade60 = 0;
            int idadef = 0;
            int fm = 0;
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Qual o seu nome ?");
                string nome = Console.ReadLine();
                Console.WriteLine("Qual o seu sexo ?");
                char sexo = char.Parse(Console.ReadLine().ToLower());
                Console.WriteLine("Qual a sua idade ?");
                int idade = int.Parse(Console.ReadLine());
                if (sexo == 'm')
                {
                    nm++;

                }
                else if (sexo == 'f')
                {
                    fm++;
                    idadef += idade;  
                }
                if ( idade <= 30)
                {
                    idade30++;
                } 
                else if (idade >= 60)
                {
                    idade60++;
                }
            }
            double media = idadef / fm;
            Console.WriteLine("Número de pessoas do sexo masculino: " + nm);
            Console.WriteLine("Número de pessoas do sexo feminino: " + fm);
            Console.WriteLine("Pessoas com idade inferioar a 30 anos : " + idade30);
            Console.WriteLine("Pessoas com idade superior a 60 anos : " + idade60);
            Console.WriteLine("Media daidade das mulheres é " + media);
        }
    }
}