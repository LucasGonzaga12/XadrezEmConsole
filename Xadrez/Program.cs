// See https://aka.ms/new-console-template for more information
using System;
using tabuleiro;
using xadrez;
namespace Xadrez {
    class Program {
        static void Main(string[] args) {
            try {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
                tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
                tab.colocarPeca(new Rei(Cor.Preta, tab), new Posicao(2, 4));

                Tela.imprimirTabuleiro(tab);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}