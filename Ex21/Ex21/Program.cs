namespace Ex21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i <= 10; i++)
            {
                double n = Math.Pow(2, i); //potencia não pode ser em número de variavel int.
                Console.WriteLine("A Potencia de 2 elevado a " + i + " é: " + n);
            }
        }
    }
}