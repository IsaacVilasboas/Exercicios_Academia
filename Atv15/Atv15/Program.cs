namespace Atv15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Agencia Bancaria");

            Console.WriteLine("Conta Corrente");
            ContaCorrente cc = new ContaCorrente(250.50);
            cc.Despostiar(250.00);
            cc.Sacar(150.00);
            Console.WriteLine();
            Console.WriteLine("Conta Poupança");
            ContaPoupança cp = new ContaPoupança(750.10);
            cp.Despostiar(150.00);
            cp.Sacar(250.00);
        }
    }
}