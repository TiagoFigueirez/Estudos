using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresLogicos {

        static public void Executar() {

            var ExecutouTrabalho1 = true;
            var ExecutouTrabalho2 = false;

            var ComprouTV50 = ExecutouTrabalho1 && ExecutouTrabalho2;

            Console.WriteLine("comprou a tv de 50 ? {0}",ComprouTV50);

            var ComprouSorvete = ExecutouTrabalho1|| ExecutouTrabalho2;

            Console.WriteLine("comprou sorvete ? {0}",ComprouSorvete);

            var ComprouTV30 = ExecutouTrabalho1 ^ ExecutouTrabalho2;

            Console.WriteLine("comprou tv de 32 ? {0}", ComprouTV30);

            Console.WriteLine("mais saudavel ? {0}", !ComprouSorvete);

        }
    }
}
