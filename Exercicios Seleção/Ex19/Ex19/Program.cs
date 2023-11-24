namespace Ex19
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
               if (n2 > n3)
                {
                    Console.WriteLine(n3+ " , " + n2 + " , " + n1);
                }
                else
                {
                    Console.WriteLine(n2 + " , " + n3 + " , " + n1);
                } 
            }
            else if (n2 > n1 && n2 > n3)
            {
                if(n1 > n3)
                {
                    Console.WriteLine(n3 + " , " + n1 + " , " + n2);
                }
                else
                {
                    Console.WriteLine(n1 + " , " + n3 + " , " + n2);
                }
            }
            else if (n3 > n1 && n3 > n2)
            {
                 if (n1 > n2)
                {
                    Console.WriteLine(n2 + " , " + n1 + " , " + n3);
                }
                else
                {
                    Console.WriteLine(n1 + " , " + n2 + " , " + n3);
                }            
            }
        }
    }
}