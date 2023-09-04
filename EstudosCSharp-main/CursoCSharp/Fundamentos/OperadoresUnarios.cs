using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresUnarios {

        public static void Executar() {

            var ValorNegativo = -5;
            var Numero1 = 2;
            var Numero2 = 3;
            var booleano = true;

            Console.WriteLine(-ValorNegativo);
            Console.WriteLine(!booleano);

            //Numero1++;
            Console.WriteLine(Numero1);

            //Numero2--;
            Console.WriteLine(Numero2);

            Console.WriteLine(Numero1++ == --Numero2);// quando a incrementação vem primeiro ela tem
                                                      // prioridade de forma que a subtração vem antes da
                                                      // comparação e quando vem depois tem prioridade a comparação
            Console.WriteLine("{0} {1}", Numero1, Numero2);


        }
    }
}
