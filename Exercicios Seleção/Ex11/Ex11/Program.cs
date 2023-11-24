namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horas, minutos;
            Console.WriteLine("Que horas é agora ?");
            horas = int.Parse(Console.ReadLine());
            minutos = horas * 60;

            if (horas < 23.59 && minutos > 60)
            {
                Console.WriteLine("Hora valida");
            }
        }
    }
}
