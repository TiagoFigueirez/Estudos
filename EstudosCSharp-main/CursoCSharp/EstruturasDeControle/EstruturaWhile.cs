using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaWhile {
        static public void Executar() {

            int palpite = 0;

            Random random = new Random ();

            int numeroScreto = random.Next(1,15);
            bool NumeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while(tentativasRestantes> 0 && !NumeroEncontrado) {
                Console.WriteLine("insira seu palpite:");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroScreto == palpite) {
                    NumeroEncontrado = true;
                    var CorAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero encontrado em {0} tentativas", tentativas);
                    Console.BackgroundColor= CorAnterior;
                }else if(palpite > numeroScreto) {
                    Console.WriteLine("menor tente novamente");
                    Console.WriteLine("tentativas restantes {0}", tentativasRestantes);
                } else {
                    Console.WriteLine("maior tente novamente");
                    Console.WriteLine("tentativas restantes {0}", tentativasRestantes);
                }
            }


        }
    }
}
