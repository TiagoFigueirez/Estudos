using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaDoWhile {

        public static void Executar() {

            string entrada;

            do {
                Console.WriteLine("qual o seu nome ?");
                entrada = Console.ReadLine();

                Console.WriteLine("seja bem vindo {0}", entrada);

                Console.WriteLine("deseja continuar ? (S/N)");
                entrada = Console.ReadLine();
            } while (entrada.ToLower()=="s");
        }
    }
}
