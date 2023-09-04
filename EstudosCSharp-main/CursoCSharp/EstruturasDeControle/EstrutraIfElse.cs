using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstrutraIfElse {
        public static void Executar() {

            double nota = 7.0;
            if(nota >=7.0) {
                Console.WriteLine("aprovado!");
                Console.WriteLine("não fez mais que a obrigação");
            } else {
                Console.WriteLine("recuperação");
            }

        }
    }
}
