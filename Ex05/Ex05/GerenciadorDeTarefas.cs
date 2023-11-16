using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    internal class GerenciadorDeTarefas
    {
        public string descrição;
        public DateTime data;

        List<GerenciadorDeTarefas>Tarefas = new List<GerenciadorDeTarefas> ();
        public GerenciadorDeTarefas(string descrição, DateTime data)
        {
            this.descrição = descrição;
            this.data = data;
        }
        public void Adicionar()
        {
            Console.WriteLine("Deseja adicionar uma nova terefa? [s/n]");
            char rep = char.Parse(Console.ReadLine().ToLower());
            if (rep == 's')
            {
                Console.WriteLine("Qual a descrição ?");
                string descrição = Console.ReadLine();
                Console.WriteLine("Qual a data?");
                DateTime data = DateTime.Parse(Console.ReadLine());
                return;
            }
            else
            {
                Console.WriteLine("Nenhuma tarefa foi adicionada");
            }

        }
        public void remoção() 
        {
            Console.WriteLine("Deseja remover tarefas [s/n]");
            char rep = char.Parse(Console.ReadLine().ToLower());
            if (rep == 's')
            {
                Console.WriteLine("Qual tarefa deseja remover ?");
                string remov = Console.ReadLine().ToLower();
                for (int i = 0; i < Tarefas.Count; i++)
                {
                    if (Tarefas[i].descrição == remov)
                    {
                        Console.WriteLine("A tarefa " + Tarefas[i].descrição + " será removida");
                        Tarefas.Remove(Tarefas[i]);
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine("Nenhuma tarefa foi removida");
            }
        }
        public void listar()
        {
            foreach (GerenciadorDeTarefas tarefas in Tarefas)
            {
                Console.WriteLine(tarefas.descrição);
                Console.WriteLine(tarefas.data);
            }
        }
        public void comparar()
        {
            DateTime dataAtual = DateTime.Now;
            Console.WriteLine("Tarefas pra hoje: ");
            for (int i = 0; i < Tarefas.Count; i++)
            {
                if (Tarefas[i].data == dataAtual)
                {
                    Console.WriteLine("A tarefa " + descrição[i] + " é pra hoje ");
                    return;
                }
                else
                {
                    Console.WriteLine("Nenhuma Tarefa pra hoje");
                }
            }
        }
    }
}
