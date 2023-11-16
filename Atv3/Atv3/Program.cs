namespace Atv3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            p.nome = "isaac";
            p.idade = 22;
            p.genero = 'M';
            Console.WriteLine("Nome: " + p.nome);
            Console.WriteLine("Idade: " + p.idade);
            Console.WriteLine("Gênero: " +  p.genero);
        }
    }
}
