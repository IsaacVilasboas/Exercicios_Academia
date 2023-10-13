namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont, soma, id, media;
            cont = 0;
            soma = 0;

            for (int i = cont; i < 4; i++)
            {
                cont = cont + 1;
                Console.WriteLine("Qual a sua idade ?");
                id = int.Parse(Console.ReadLine());
                soma = soma + id;
            }
            media = soma / cont;
            Console.WriteLine(media);
        }
    }
}
