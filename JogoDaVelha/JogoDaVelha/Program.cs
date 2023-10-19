namespace JogoDaVelha
{
    internal class Program
    {
        static char[,] jogo = new char[3, 3]; 
        static char jogadorAtual = 'X';
        static bool jogoEmAndamento = true; 

        static void Main()
        {
            while (true)
            {
                InicializarTabela(); 
                jogoEmAndamento = true;

                while (jogoEmAndamento)
                {
                    ExibirTabela(); 
                    Jogada(); 
                    ExibirTabela();

                    if (VerificarVitoria(jogadorAtual))
                    {
                        ExibirTabela();
                        Console.WriteLine("Jogador " + jogadorAtual + " venceu!");
                        jogoEmAndamento = false; 
                    }
                    else if (VerificarEmpate())
                    {
                        ExibirTabela();
                        Console.WriteLine("O jogo terminou em empate!");
                        jogoEmAndamento = false; 
                    }
                    else
                    {
                        TrocarJogador(); 
                    }
                }

                Console.Write("Deseja jogar novamente? (S/N): ");
                if (Console.ReadLine().ToUpper() != "S")
                {
                    break; 
                }
            }
        }

        static void InicializarTabela()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    jogo[i, j] = ' '; 
                }
            }
        }
        static void TrocarJogador()
        {
            if(jogadorAtual == 'X')
            {
                jogadorAtual = 'O';
            }
        else
            {
                jogadorAtual = 'X';
            }
        }

        static void ExibirTabela()
        {
            Console.Clear();
            Console.WriteLine("Jogo da Velha");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(jogo[i, j]); 
                    if (j < 2)
                    {
                        Console.Write("  | ");
                    }
                }
                Console.WriteLine();
                if (i < 2)
                {
                    Console.WriteLine("---+----+---");
                }
            }
            Console.WriteLine();
        }

        static void Jogada()
        {
            int linha, coluna;

            while (true)
            {
                Console.Write("Vez do jogador " + jogadorAtual + " . Escolha a linha (0, 1, 2): ");
                linha = int.Parse(Console.ReadLine());
                Console.Write("Escolha a coluna (0, 1, 2): ");
                coluna = int.Parse(Console.ReadLine());

                if (linha >= 0 && linha < 3 && coluna >= 0 && coluna < 3 && jogo[linha, coluna] == ' ')
                {
                    jogo[linha, coluna] = jogadorAtual; 
                    break; 
                }
                else
                {
                    Console.WriteLine("Jogada inválida. Tente novamente.");
                }
            }
        }

        static bool VerificarVitoria(char jogador)
        {
            
            for (int i = 0; i < 3; i++)
            {
                if (jogo[i, 0] == jogador && jogo[i, 1] == jogador && jogo[i, 2] == jogador)
                    return true; 
            }

          
            for (int j = 0; j < 3; j++)
            {
                if (jogo[0, j] == jogador && jogo[1, j] == jogador && jogo[2, j] == jogador)
                    return true; 
            }

          
            if (jogo[0, 0] == jogador && jogo[1, 1] == jogador && jogo[2, 2] == jogador)
                return true;

          
            if (jogo[0, 2] == jogador && jogo[1, 1] == jogador && jogo[2, 0] == jogador)
                return true;

            return false; 
        }

        static bool VerificarEmpate()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (jogo[i, j] == ' ')
                    {
                        return false; 
                    }
                }
            }
            return true; 
        }

    }
}