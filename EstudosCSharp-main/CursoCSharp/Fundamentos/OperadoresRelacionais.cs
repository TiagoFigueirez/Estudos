using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresRelacionais {

        static public void Executar() {

            double nota = 7.5;
            double NotadeCorte = 7.0;

            Console.WriteLine("Nota Invalida ? {0}", nota >10.0);
            Console.WriteLine("Nota Invalida ? {0}", nota < 10.0);
            Console.WriteLine("Nota Invalida ? {0}", nota == 10.0);
            Console.WriteLine("tem como melhorar ? {0}", nota != 10.0);
            Console.WriteLine("passou por media ? {0}", nota >= NotadeCorte);
            Console.WriteLine("recuperação ? {0}", nota < NotadeCorte);
            Console.WriteLine("Reprovado ? {0}", nota <=3.0);
        }
    }
}
