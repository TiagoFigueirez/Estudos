using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class operadorTernario {
        public static void Executar() {

            var nota = 7.0;
            string resultado = nota > 7.0 ? "aprovado" : "reprovado"; // ternario tem tres operações

                Console.WriteLine(resultado);
        }
    }
}
