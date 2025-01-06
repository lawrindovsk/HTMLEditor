using System;
using System.Threading;

namespace Editor
{
    public static class Menu
    {
        internal static void Mostrar()
        {
            Console.Clear(); // Limpa a tela do console
            Console.BackgroundColor = ConsoleColor.DarkGray; // Define a cor de fundo do console
            Console.ForegroundColor = ConsoleColor.White; // Define a cor do texto do console
            Thread.Sleep(5000); // Aguarda 5 segundos
            Console.WriteLine("Pressione qualquer tecla para iniciar!"); // Exibe uma mensagem
            Console.ReadKey(); // Aguarda o usuário pressionar uma tecla
            DesenharTela(); // Chama a função para desenhar a tela
            Console.ReadKey(); // Aguarda o usuário pressionar uma tecla novamente
        }

        public static void DesenharTela()
        {
            int largura = Console.WindowWidth - 1; //ele pega a largura da janela em que esta sendo executado o programa.
            int altura = Console.WindowHeight - 1; //mesma coisa da largura, porém para altura.

            while (true) // Loop infinito para verificar mudanças no tamanho da janela!
            {
                if (Console.WindowWidth - 1 != largura || Console.WindowHeight - 1 != altura) // Verifica se o tamanho da janela mudou
                {
                    largura = Console.WindowWidth - 1; // Atualiza a largura
                    altura = Console.WindowHeight - 1; // Atualiza a altura
                    Console.Clear(); // Limpa a tela do console

                    // Desenha a linha superior
                    Console.Write("+"); //O caracter que vai usar para desenhar na tela.
                    for (int i = 0; i < largura - 2; i++) //inicia com o "contador" no zero, e sera de acordo com a largura que o usuario esta utilizando a janela. -2 para se adequar a indice {0}, ja que ainda não sabemos o tamanho. Desenha linha superior.
                        Console.Write("-");//Desenha os ifens para simular o quadrado.
                    Console.Write("+"); // desenha no canto superior direito, as pontas.
                    Console.Write("\n"); // Pula para a próxima linha

                    // Desenha as linhas laterais
                    for (int linhas = 0; linhas < altura - 2; linhas++) // Para cada linha da altura
                    {
                        Console.Write("|"); // Desenha a borda esquerda usando pipe.
                        for (int i = 0; i < largura - 2; i++) // desenha linha lateral.
                            Console.Write(" "); //utiiza do espaço para fazer divisoria. 
                        Console.Write("|"); // Desenha as bordas simulando o quadrado.
                        Console.Write("\n"); //.pula
                    }

                    Console.Write("+");//O caracter que vai usar para desenhar na tela.
                    for (int i = 0; i < largura - 2; i++)//inicia com o "contador" no zero, e sera de acordo com a largura que o usuario esta utilizando a janela. -2 para se adequar a indice {0}, ja que ainda não sabemos o tamanho.
                        Console.Write("-");//Desenha os ifens para fechar a janelinha.
                    Console.Write("+");//desenha nas pontas.
                    Console.Write("\n");//pula a linha para seguir a sequencia do quadrado desenhado.
                }
                //Thread.Sleep(100); // Pequeno delay para evitar uso excessivo de CPU
            }
        }
    }
}