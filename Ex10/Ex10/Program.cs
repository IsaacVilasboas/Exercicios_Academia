namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1 = Console.ReadLine();
            int idade1 = int.Parse(Console.ReadLine());
            float altura1 = float.Parse(Console.ReadLine());
            string nome2 = Console.ReadLine();
            int idade2 = int.Parse(Console.ReadLine());
            float altura2 = float.Parse(Console.ReadLine());

            if (idade1 < idade2 && altura1 > altura2)
            {
                Console.WriteLine(nome1);
                Console.WriteLine(idade1);
                Console.WriteLine(altura1);
            }
            else if(idade1 > idade2 && altura1 < altura2)
            {
                Console.WriteLine(nome2);
                Console.WriteLine(idade2);
                Console.WriteLine(altura2);
            } 
        }
    }
}
//faça um programa no vs que receba dados de dois atletas (nome, idade e altura).
//o programa deve mostrar os dados do atleta mais novo e mais alto.