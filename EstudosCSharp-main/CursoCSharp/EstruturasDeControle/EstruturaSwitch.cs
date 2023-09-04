using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaSwitch {

        public static void Executar() {

            Console.WriteLine("avalie meu atendimento de 0 a 4:");

            int.TryParse(Console.ReadLine(), out int nota);

            switch(nota) {
                case 0:
                    Console.WriteLine("pessimo!");
                    break;
                case 1:
                    Console.WriteLine("Ruim");
                    break;
                case 2:
                    Console.WriteLine("medio");
                    break;
                case 3:
                    Console.WriteLine("Otimo");
                    break;
                case 4:
                    Console.WriteLine("Exelente");
                    break;
                default:
                    Console.WriteLine("numero invalido");
                    break;
            }
        }
    }
}
