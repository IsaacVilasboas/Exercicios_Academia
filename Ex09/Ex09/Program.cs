namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {


                Console.WriteLine("digite um número inteiro positivo");
                int numero = int.Parse(Console.ReadLine());

                while (numero <= 0)
                {
                    Console.WriteLine("número invalido");
                    numero = int.Parse(Console.ReadLine());
                }
                if (numero > 0)
                {
                    Console.WriteLine("número digitado foi: " + numero);
                    for (int i = 2; i < numero; i += 2)
                    {
                        Console.Write(i + ",");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Deseja informar outro número (s/n)? ");
            } while (Console.ReadLine().ToLower() == "s");
        }
    }
}  