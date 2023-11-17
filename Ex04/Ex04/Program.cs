namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AgendaTelefonica> agenda = new List<AgendaTelefonica>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Digite o nome do contato");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o número de telefone:");
                string telefone = Console.ReadLine();
                Console.WriteLine("Digite o email");
                string email = Console.ReadLine();

                AgendaTelefonica ag = new AgendaTelefonica(nome, telefone, email);

                agenda.Add(ag);
            }

            MostrarAgenda(agenda);
            buscar(agenda);
            remove(agenda);
            MostrarAgenda(agenda);

        }

        static void MostrarAgenda(List<AgendaTelefonica> agenda)
        {
            Console.WriteLine();
            Console.WriteLine("Mostrar Lista de contato");
            foreach (AgendaTelefonica contato in agenda)
            {
                Console.WriteLine("Contato: " + contato.nome + " Telefone: " + contato.telefone + " email: " + contato.email);
            }

        }
        static void buscar(List<AgendaTelefonica> agenda )
        {
            
            Console.WriteLine();
            Console.WriteLine("Buscar contato");
            Console.WriteLine("Qual contato deseja buscar ?");
            string busc = Console.ReadLine().ToLower();
            for (int i = 0; i < agenda.Count; i++)
            {
                if (agenda[i].nome == busc)
                {
                    Console.WriteLine("Contato encontrado");
                    Console.Write("contato: " + agenda[i].nome + " ");
                    Console.Write(agenda[i].telefone + " ");
                    Console.Write(agenda[i].email + " ");
                    return;
                }
            }
            Console.WriteLine("Contato não encontrado");
        }
        static void remove(List<AgendaTelefonica> agenda)
        {
            Console.WriteLine();
            Console.WriteLine("Remover contato");
            Console.WriteLine("Qual contato deseja remover ?");
            string remov = Console.ReadLine().ToLower();
            for (int i = 0; i < agenda.Count; i++)
            {
                if (agenda[i].nome == remov)
                {
                    agenda.Remove(agenda[i]);
                    return;
                }
            }
            Console.WriteLine("Contato não encontrado");
        }
    }
}