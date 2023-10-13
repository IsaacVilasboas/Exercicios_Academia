namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 3];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Informe os valores para a primeira coluna:");
                matriz[i, 0] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                matriz[i, 1] = matriz[i, 0] + 10;
               
            }
            for (int i = 0; i < 5; i++)
            {
                matriz[i, 2] = matriz[i, 0] * 2;
            }
            Console.WriteLine("Resultado:");
            for (int i = 0;i < 5; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write( "[" + matriz[i, j] + "]");
                }
                Console.WriteLine();
            }
        }
    }
}
