using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv11
{
    internal class Livro
    {
        public bool emprestado;
        public string título;
        public string autor;
        public string pag;

        public Livro(bool emprestado, string título, string autor, string pag)
        {
            this.emprestado = false;
            this.título = título;
            this.autor = autor;
            this.pag = pag;
        }
        public void Emprestar()
        {
            if (!emprestado)
            {
                emprestado = true;
                Console.WriteLine("O livro " + título + " pode ser emprestado");
            }
            else
            {
                Console.WriteLine("O livro " + título + " já está emprestado");
            }

        }
        public void Devolver()
        {
            if (emprestado)
            {
                emprestado = false;
                Console.WriteLine("O livro " + título + " já foi devolvido");
            }
            else
            {
                Console.WriteLine("O livro " + título + " não estava emprestado");
            }
        }
        public void Livro1()
        {
            Console.WriteLine("Qual o Título do livro?");
            título = Console.ReadLine();
            Console.WriteLine("Qual o nome do autor do livro");
            autor = Console.ReadLine();
            Console.WriteLine("Quantas páginas tem o livro ?");
            pag = Console.ReadLine();
        }
        public void Livro2()
        {
            Console.WriteLine("Qual o Título do livro?");
            título = Console.ReadLine();
            Console.WriteLine("Qual o nome do autor do livro");
            autor = Console.ReadLine();
            Console.WriteLine("Quantas páginas tem o livro ?");
            pag = Console.ReadLine();
        }
    }
}
