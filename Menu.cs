using System;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;

namespace Editor
{
    public static class Menu
    {
        internal static void Mostrar()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(5000);
            Console.WriteLine("Pressione qualquer tecla para iniciar!");
            Console.ReadKey();
            DesenharTela();
            Console.ReadKey();

        }

        public static void DesenharTela()
        {
            int largura = Console.WindowWidth - 1;//ele pega a largura da janela em que esta sendo executado o programa.
            int altura = Console.WindowHeight - 1;//mesma coisa da largura, porém para altura.

            // Desenha a linha superior
            Console.Write("+");//O caracter que vai usar para desenhar na tela.
            for (int i = 0; i < largura - 2; i++)//inicia com o "contador" no zero, e sera de acordo com a largura que o usuario esta utilizando a janela. -2 para se adequar a indice {0}, ja que ainda não sabemos o tamanho.
                Console.Write("-");//Desenha os ifens para simular o quadrado.
            Console.Write("+");//desenha nas pontas.
            Console.Write("\n");//pula.

            // Desenha as linhas laterais
            for (int linhas = 0; linhas < altura - 2; linhas++)
            {
                Console.Write("|");
                for (int i = 0; i < largura - 2; i++)
                    Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }

            // Desenha a linha inferior
            Console.Write("+");//O caracter que vai usar para desenhar na tela.
            for (int i = 0; i < largura - 2; i++)//inicia com o "contador" no zero, e sera de acordo com a largura que o usuario esta utilizando a janela. -2 para se adequar a indice {0}, ja que ainda não sabemos o tamanho.
                Console.Write("-");//Desenha os ifens para fechar a janelinha.
            Console.Write("+");//desenha nas pontas.
            Console.Write("\n");//pula a linha para seguir a sequencia do quadrado desenhado.
        }
    }
}