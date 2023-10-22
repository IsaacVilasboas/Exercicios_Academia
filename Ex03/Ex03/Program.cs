namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont,x, soma;
            cont = 0;
            Console.WriteLine("digite um número para fazermos a sua tabuada");
            x = int.Parse(Console.ReadLine());
            
            while (cont < 10 ) {
                cont++;
                soma = cont * x;
                Console.WriteLine( x + " x " + cont + " : " + soma);
            }
        }
    }
}