using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace NivelHeroi.Models
{
    public class Heroi
    {
        public Heroi(int vitoria, int derrota)
        {
            Vitoria = vitoria;
            Derrota = derrota;
        }

        public int Vitoria { get; set; } = 0;
        public int Derrota { get; set; } = 0;

        public void Nivel()
        {
            int final = Vitoria - Derrota;

            if (final < 10)

                Console.WriteLine("Ferro");

            else if (final > 11 && final <= 20)
                Console.WriteLine("Bronze");

            else if (final > 21 && final <= 50)
                Console.WriteLine("Prata");

            else if (final > 51 && final <= 80)
                Console.WriteLine("Ouro");

            else if (final > 81 && final <= 90)
                Console.WriteLine("Diamante");

            else if (final > 91 && final <= 100)
                Console.WriteLine("Lendario");

            else if (final > 101)
                Console.WriteLine("Imortal");
            else
            {
                Console.WriteLine("Tente outra vez!!");
            }

            Console.WriteLine($"O herói está com {final} vitórias!! ");
        }

        public void ExibirPerfil()
        {

            Console.WriteLine("Nível atual: ");

            


        }
    }
}