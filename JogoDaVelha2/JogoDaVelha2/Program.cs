namespace JogoDaVelha2
{
    internal class Program
    {
        static char[,] jogo = new char[3, 3];
        static char jogador = 'X';
        static char computador = 'O';
        static bool AndamentoJogo = true;

        static void Main(string[] args)
        {
            string continuar;

            do
            {

                InicializarJogo();
                JogadaComputador();
                MostrarJogo();
                while (AndamentoJogo)
                {
                    JogadaJogador();

                    if (VitoriaJogador(jogador))
                    {
                        MostrarJogo();
                        Console.WriteLine("Parabêns!! Você ganhou");
                        break;

                    }
                    if (VitoriaComputador(computador))
                    {
                        MostrarJogo();
                        Console.WriteLine("Infelizmente você perdeu..");
                        break;

                    }
                    if (Empate())
                    {
                        MostrarJogo();
                        Console.WriteLine("O jogo ficou empatado");
                        break;

                    }
                    else
                    {
                        MostrarJogo();
                        JogadaComputador();
                        MostrarJogo();
                        if (VitoriaJogador(jogador))
                        {
                            MostrarJogo();
                            Console.WriteLine("Parabêns!! Você ganhou");
                            break;

                        }
                        else if (VitoriaComputador(computador))
                        {
                            MostrarJogo();
                            Console.WriteLine("Infelizmente você perdeu..");
                            break;

                        }
                        else if (Empate())
                        {
                            MostrarJogo();
                            Console.WriteLine("O jogo terminou empatado...");
                            break;

                        }
                    }
                }
                Console.WriteLine("Deseja Jogar novamente? [S/N]");
                continuar = Console.ReadLine().ToUpper();
            } while (continuar == "S");

        Console.WriteLine("Jogo Finalizado");

    }

        static void InicializarJogo()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    jogo[i, j] = ' ';
                }
            }
        }
        static void MostrarJogo()
        {
            Console.Clear();
            Console.WriteLine("****Jogo Da Velha****");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(jogo[i, j]);
                    if (j < 2)
                    {
                        Console.Write("   | ");
                    }
                }
                Console.WriteLine();
                if (i < 2)
                {
                    Console.WriteLine("----+-----+----");
                }
            }
            Console.WriteLine();
        }
        static void JogadaComputador()
        {
            for(int i  = 0; i < 3; ++i)
            {
                for(int j = 0;j < 3; j++)
                {
                    if (jogo[i, j] == ' ')
                    {
                        jogo[i, j] = computador;
                        if (VitoriaComputador(computador))
                        {   // O jogo vai verificar se tem algum espaço para completar e vencer a partida
                            return;
                        }
                        jogo[i, j] = ' ';
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (jogo[i, j] == ' ')
                    {
                        jogo[i, j] = jogador;
                        if (VitoriaJogador(jogador))
                        {//O Computador vai bloquear a jogada do jogador
                            jogo[i, j] = computador;
                            return;
                        }
                        jogo[i, j] = ' ';
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (jogo[i, j] == ' ')
                    {
                        jogo[i, j] = computador;
                        return;
                    }

                    if (jogo[i, j + 2] != ' ')
                    {
                        if (jogo[i + 2, j] == ' ')
                        {
                            jogo[i + 2, j] = computador;
                            return;
                        }
                    }

                    if (jogo[i , j + 2] == ' ')
                    {
                        jogo[i , j + 2] = computador;
                        return;
                    }

                    if (jogo[i + 1 , 1 + j] == ' ')
                    {
                        jogo[ i + 1, j + 1] = computador;
                        return;
                    }

                    if (jogo[i + 2 ,j + 2] == ' ')
                    {
                        jogo[i + 2, j + 2] = computador;
                        return;
                    }
                    
                    if (jogo[i , j + 1] == ' ')
                    {
                        jogo[i , j + 1] = computador;
                        return;
                    }

                    if (jogo[i + 2 , j + 1] == ' ')
                    {
                        jogo[i + 2 , j + 1] = computador;
                        return;
                    }
                }
            }
            
        }
        static void JogadaJogador()
        {
            int linha, coluna;
            while (true)
            {
                Console.WriteLine("Vez do Jogador.Escolha uma linha(0, 1, 2): ");
                linha = int.Parse(Console.ReadLine());
                Console.WriteLine("Escolha uma coluna (0, 1, 2):");
                coluna = int.Parse(Console.ReadLine());

                if (linha >= 0 && linha < 3 && coluna >= 0 && coluna < 3 && jogo[linha, coluna] == ' ')
                {
                    jogo[linha, coluna] = jogador;
                    break;
                }
                else
                {
                    Console.WriteLine("Jogada invalida, tente novamente.");
                }
            }
        }
        static bool VitoriaJogador(char jogador)
        {
            for (int i = 0; i < 3; i++)
            {
                if (jogo[i, 0] == jogador && jogo[i, 1] == jogador &&   jogo[i, 2] == jogador)
                    return true;
                if (jogo[0, i] == jogador && jogo[1, i] == jogador && jogo[2, i] == jogador)
                    return true;
            }

            if (jogo[0, 0] == jogador && jogo[1, 1] == jogador && jogo[2, 2] == jogador)
                return true;
            if (jogo[0, 2] == jogador && jogo[1, 1] == jogador && jogo[2, 0] == jogador)
                return true;

            return false;
        }
        static bool VitoriaComputador(char computador)
        {
            for (int i = 0; i < 3; i++)
            {
                if (jogo[i, 0] == computador && jogo[i, 1] == computador && jogo[i, 2] == computador)
                    return true;
                if (jogo[0, i] == computador && jogo[1, i] == computador && jogo[2, i] == computador)
                    return true;
            }

            if (jogo[0, 0] == computador && jogo[1, 1] == computador && jogo[2, 2] == computador)
                return true;
            if (jogo[0, 2] == computador && jogo[1, 1] == computador && jogo[2, 0] == computador)
                return true;

            return false;
        }
        static bool Empate()
        {
            for (int i = 0;i < 3;i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (jogo[i,j] == ' ')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    } 
}
