namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("WheyProtein", "R$ 150,00", 100);

            Console.WriteLine("O nome do produto é: " + p.nome);
            Console.WriteLine("O valor: " + p.preço);
            Console.WriteLine("Estoque Atual:" + p.quantEstoq);
            p.Adc();
            Console.WriteLine("Estoque Atual:" + p.quantEstoq);
            p.Remov();
            Console.WriteLine("Estoque Atual:" + p.quantEstoq);
        }
    }
}