namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<GerenciadorDeTarefas> Tarefas = new List<GerenciadorDeTarefas>();
            Console.WriteLine("Qual a descrição ?");
            string descrição = Console.ReadLine();
            Console.WriteLine("Qual a data?");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("descrição: " + descrição);
            Console.WriteLine("Data: " + data);

            GerenciadorDeTarefas gt = new GerenciadorDeTarefas(descrição, data);

            gt.Adicionar();
            gt.remoção();
            gt.comparar();
            gt.comparar();
            Tarefas.Add(gt);

            foreach (GerenciadorDeTarefas tarefas in Tarefas)
            {
                Console.WriteLine(tarefas.descrição);
                Console.WriteLine(tarefas.data);
            }
        }
    }
}