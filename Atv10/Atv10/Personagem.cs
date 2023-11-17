using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv10
{
    internal class Personagem
    {
        Random random = new Random();
        public string nome;
        public int posição;
        public int itensColetados = 0;

        public void Jogo()
        {
            string continuar;
            Nome();
            
            do { 
            movimento();
            Atacar();
            Console.WriteLine("Deseja movimentar novamente? [S/N]");
            continuar = Console.ReadLine().ToUpper();
            } while (continuar == "S");
            Console.WriteLine("Itens coletados: " + itensColetados);
            Console.WriteLine("Descansar");
        }

        public void Nome()
        {
            Console.WriteLine("Qual o nome do Personagem?");
            nome = Console.ReadLine();
            
        }
        public void Atacar()
        {
            string continuar;
            char item;
            
            do
            {
                Console.Write("Dano:");
                double atk = double.Parse(Console.ReadLine());
                while (atk != 0)
                {
                    Console.WriteLine("O seu dano é: " + atk);
                    int vidaMob = random.Next(0,2);
                    if (vidaMob == 1)
                    {
                        Console.WriteLine("Caramba ele ainda não morreu");
                        Console.Write("Dano:");
                        atk = double.Parse(Console.ReadLine());
                    }
                    break;

                }
                Console.WriteLine("Verificar se o Mob dropou algum item [S/N]");
                item = char.Parse(Console.ReadLine().ToUpper());
                if (item == 'S')
                {
                    int sorte = random.Next(0,2);
                    if (sorte == 1)
                    {
                    Console.WriteLine("O mob não dropou nenhum item");
                    }
                    else
                    {
                    Console.WriteLine("Opaaa, Dropamos um item");
                    itensColetados++;
                    }
                }
                Console.WriteLine("Vamos para o proximo");
                Console.WriteLine("Deseja atacar ?");
                continuar = Console.ReadLine().ToUpper();
            } while (continuar == "S");
           
        }
        public void movimento()
        {
            string continuar;
            Console.WriteLine("Olá, " + nome + ". Iniciaremos a nossa jornada!!");
            Console.WriteLine("Posição inicial = centro");
            do
            {

                Console.WriteLine("Para que direção deseja se mover ? 1 - frente, 2 - trás, 3 - direita e 4 - esquerda, 0 para permanecer parado");
                posição  = int.Parse (Console.ReadLine());
                while (posição >= 0)
                {
                    if (posição == 1)
                    {
                        Console.WriteLine("'(1)' Você está se movendo para frente");
                        
                        break;
                    }
                    else if (posição == 2)
                    {
                        Console.WriteLine("'(2)' Você está se movendo para trás");
                        break;
                    }
                    else if (posição == 3)
                    {
                        Console.WriteLine("'(3)' Você está se movendo para direita");
                        break;
                    }
                    else if (posição == 4)
                    {
                        Console.WriteLine("'(4)' Você está se movendo para esquerda");
                        break;
                    }
                    else if(posição == 0) 
                    {
                        Console.WriteLine("'(0)'VocÊ permaneceu parado");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Número informado invalido, digite novamente");
                        break;
                    }
                }
                Console.WriteLine("Deseja movimentar novamente? [S/N]");
                continuar = Console.ReadLine().ToUpper();
            } while (continuar == "S");
            Console.WriteLine("Verficar se existe mobs ao redor");
            Console.WriteLine("Mob encotrado, atacar!!");
        }    
    }
}
