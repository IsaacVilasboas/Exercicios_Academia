namespace Atv17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Agencia Bancaria");

            Console.WriteLine("Conta Corrente");
            ContaCorrente cc = new ContaCorrente(250.05);
            cc.Depositar(10);
            cc.Sacar(150.00);
            Console.WriteLine();
            Console.WriteLine("Conta Poupança");

            Conta_Poupança cp = new Conta_Poupança(750.10);
            cp.Depositar(50);
            cp.Sacar(250.00);
        }
    }
}