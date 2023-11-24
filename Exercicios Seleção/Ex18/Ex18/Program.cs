namespace Ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite 3 valores");
            string[] vet = Console.ReadLine().Split(' ');
            int n1 = int.Parse(vet[0]);
            int n2 = int.Parse(vet[1]);
            int n3 = int.Parse(vet[2]);

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine(n1 + " é o maior");
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine(n2 + " é o maior");
            }
            else if (n3 > n1 && n3 > n2)
            {
                Console.WriteLine(n3 + " é o maior");
            }
        }
    }
}