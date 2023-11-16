using System.Globalization;

namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var fabricante = new Fabricante();
            fabricante.Nome = "Fox Cell";
            fabricante.Endereço = "Travessa do Mercado n21";
            fabricante.Cidade = "Caetité Ba";

            var produto = new Produto();
            produto.Fabricante = fabricante;
            produto.Nome = "Celular A02";
            produto.Preço = 250.00;

            Console.WriteLine("Nome da Empresa: " + fabricante.Nome);
            Console.WriteLine("O endereço: " + fabricante.Endereço);
            Console.WriteLine("A Cidade: " + fabricante.Cidade);
            Console.WriteLine("Produto: " + produto.Nome);
            Console.WriteLine("Preço: " + produto.Preço.ToString("F2"),CultureInfo.InvariantCulture);
            Console.WriteLine("Nome do fabricante: " + produto.Fabricante.Nome);


        }
    }
}