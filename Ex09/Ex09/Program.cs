namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animal = new Animal();
            animal.Nome = "Luna";
            animal.Especie = "Cachorro";
            animal.Idade = 10;

            Console.WriteLine("Nome do animal: " + animal.Nome);
            Console.WriteLine("Nome da especie: " + animal.Especie);
            Console.WriteLine("A idade: " + animal.Idade);
            animal.EmitirSom();
            

        }
    }
}