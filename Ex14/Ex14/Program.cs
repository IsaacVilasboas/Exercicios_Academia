namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("qual o tamano do aquivo (MB)");
            int mb = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é a velocidade de sua internet ?");
            int net = int.Parse(Console.ReadLine());

            double seg = mb / net;
            seg = seg / 60;
            Console.WriteLine(seg.ToString("F0"));
        }
    }
}