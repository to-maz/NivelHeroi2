using System;

namespace NivelHeroi.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação de instâncias da classe Heroi com diferentes valores de vitórias e derrotas
            Heroi heroi1 = new Heroi(10, 5);
            Heroi heroi2 = new Heroi(200, 10);
            Heroi heroi3 = new Heroi(100, 10);

            // // Exibir os níveis dos heróis
            // Console.WriteLine("Nível do herói 1:");

            // heroi1.Nivel();

            // Console.WriteLine("\nNível do herói 2:");
            // heroi2.Nivel();

            // Console.WriteLine("\nNível do herói 3:");
            // heroi3.Nivel();
            Console.Clear();
            Console.WriteLine("Welcome Reryzan!!!");
            

            heroi1.ExibirPerfil();
            heroi1.Nivel();

            // heroi2.ExibirPerfil();
            // heroi2.Nivel();

            // heroi3.Nivel();
            // heroi3.ExibirPerfil();
        }

    }
}