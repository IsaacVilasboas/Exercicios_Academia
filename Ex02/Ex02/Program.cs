namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<RegistroDeCompras> ListaRegistos= new List<RegistroDeCompras>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Qual foi a data da compra ?");
                string data = Console.ReadLine();
                Console.WriteLine("Qual foi o nome do produto?");
                string produto = Console.ReadLine();
                Console.WriteLine("Qual o valor ?");
                string valor = Console.ReadLine();
            
                RegistroDeCompras registro = new RegistroDeCompras(data,produto,valor);

                ListaRegistos.Add(registro);

            }

            foreach(RegistroDeCompras registro in ListaRegistos)
            {
                Console.WriteLine("data: " + registro.data);
                Console.WriteLine("produto: " + registro.produto);
                Console.WriteLine("valor: " + registro.valor);
            }
        }
    }
}