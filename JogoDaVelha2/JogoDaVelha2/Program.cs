namespace JogoDaVelha2
{
    internal class Program
    {
        static char[] vet = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        static char p1 = 'X';
        static char pc = 'O';
        static bool AndamentoJogo = true;
            
        static void Main(string[] args)
        {
            string play;
            do 
            {
                InicializarJogo();
                JogadaPc();
                MostrarJogo();
                while (AndamentoJogo)
                {
                    JogadaP1();
                    MostrarJogo();
                    if (VitoriaP1(p1))
                    {
                        MostrarJogo();
                        Console.WriteLine("Parabens!! Você Venceu!!");
                        break;
                    }
                    if (VitoriaPc(pc))
                    {
                        MostrarJogo();
                        Console.WriteLine("O computador venceu!");
                        break;
                    }
                    if (Empate())
                    {
                        MostrarJogo();
                        Console.WriteLine("O jogo Ficou Empatado...");
                        break;
                    }
                    else
                    {
                        MostrarJogo();
                        JogadaPc();
                        MostrarJogo();
                        if (VitoriaP1(p1))
                        {
                            MostrarJogo();
                            Console.WriteLine("Parabens!! Você Venceu!!");
                            break;
                        }
                        else if (VitoriaPc(pc))
                        {
                            MostrarJogo();
                            Console.WriteLine("O computador venceu!");
                            break;
                        }
                        else if (Empate())
                        {
                            MostrarJogo();
                            Console.WriteLine("O Jogo Ficou Empatado...");
                            break;
                        }
                    }
                }
            Console.WriteLine("Deseja Jogar novamente? [S/N]");
            play = Console.ReadLine().ToUpper();
            } while (play == "S");

            Console.WriteLine("Jogo finalizado");
        }
        private static void InicializarJogo()
        {
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = ' ';
            }
        }
        static bool Empate()
        {
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] == ' ')
                {
                    return false;
                }
            }
            return true;
        }
        static void JogadaPc()
        {
            if (vet[0] == ' ')
            {
                vet[0] = pc;
                return;
            }
            if (vet[2] == p1)
            {
                if (vet[6] == ' ')
                {
                    vet[6] = pc;
                    return;
                }
            }
           
            for (int i = 0; i < 9; i++)
            {
                if (vet[i] == ' ')
                {
                    vet[i] = pc;
                    if (VitoriaPc(pc))
                    {
                        return;
                    }
                    vet[i] = ' ';
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (vet[i] == ' ')
                {
                    vet[i] = p1;
                    if (VitoriaP1(p1))
                    {
                        vet[i] = pc;
                        return;
                    }
                    vet[i] = ' ';
                }
            }
            if (vet[4] == ' ')
            {
                vet[4] = pc;
                return;
            }
            int[] fim = { 6, 8 };
            foreach (int i in fim)
            {
                if (vet[i] == ' ')
                {
                    vet[i] = pc;
                    return;
                }
            }
            for (int i =0; i < 9; i++)
            {
                if (vet[i] == ' ') 
                {
                    vet[i] = pc;
                    return;
                }
            }
        }
        static void JogadaP1()
        {
            string pos;
            int p;
            do
            {
                Console.Write("Escolha uma posição de 1 a 9: ");
                pos = Console.ReadLine();

                if (!int.TryParse(pos, out p) || p < 1 || p > 9 || vet[p - 1] == 'X' || vet[p - 1] == 'O')
                {
                    Console.WriteLine("Posição inválida, tente novamente");
                    
                }

            } while (!int.TryParse(pos, out p) || p< 1 || p> 9 || vet[p - 1] == 'X' || vet[p - 1] == 'O');
            vet[p - 1] = p1;
        }
        private static void MostrarJogo()
        {
            Console.Clear();
            Console.WriteLine("****JOGO DA VELHA****");
            
            Console.WriteLine($" {vet[0]} | {vet[1]} | {vet[2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {vet[3]} | {vet[4]} | {vet[5]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {vet[6]} | {vet[7]} | {vet[8]} ");
            Console.WriteLine();
        }
        static bool VitoriaP1(char p1)
        {
            for (int i = 0; i < 3; i++)
            {
                if (vet[i * 3] == p1 && vet[i * 3 + 1] == p1 && vet[i * 3 + 2] == p1)
                {
                    return true;
                }
                if (vet[i] == p1 && vet[i + 3] == p1 && vet[i + 6] == p1)
                {
                    return true;
                }
            }
            if (vet[0] == p1 && vet[4] == p1 && vet[8] == p1)
            {
                return true;
            }
            if (vet[2] == p1 && vet[4] == p1 && vet[6] == p1)
            {
                return true;
            }
            return false;
        }
        static bool VitoriaPc(char pc)
        {
            for (int i = 0; i < 3; i++)
            {
                if (vet[i * 3] == pc && vet[i * 3 + 1] == pc && vet[i * 3 + 2] == pc)
                {
                    return true;
                }
                if (vet[i] == pc && vet[i + 3] == pc && vet[i + 6] == pc)
                {
                 return true; 
                }
            }
            if (vet[0] == pc && vet[4] == pc && vet[8] == pc)
            {
                return true;
            }
            if (vet[2] == pc && vet[4] == pc && vet[6] == pc)
            {
                return true;
            }
            return false;
        }
    }
}
