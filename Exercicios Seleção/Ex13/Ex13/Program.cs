namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
        

            Console.WriteLine("Qual a sua altura?");
            double altura = double.Parse(Console.ReadLine()); 
            double h = (72.7 *  altura) - 58;
            double m = (62.1 * altura) - 44.7;
            Console.WriteLine("Peso ideal para Homens é : " +h);
            Console.WriteLine("Peso ideal para mulheres é : "+m);
        }
    }
}