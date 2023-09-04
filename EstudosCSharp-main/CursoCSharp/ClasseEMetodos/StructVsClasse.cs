using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseEMetodos
{
    internal class StructVsClasse
    {
        public struct SPonto
        {
            public int X;
            public int Y;
        }
        public class Ponto
        {
            public int X;
            public int Y;
        }
        public static void Executar()
        {
            SPonto ponto1 = new SPonto {X=1, Y = 2};
            SPonto copiaPonto1 = ponto1;
            ponto1.X = 3;

            Console.WriteLine("valor do ponto 1 é : {0}",ponto1.X);
            Console.WriteLine("valor do copiaPonto1 é:{0}", copiaPonto1.X);
            //copia ponto não herdar o valor que atribuimos de X do ponto 1 por que a atribuição e por valor
            // isso e uma particularidade da struct

            Ponto ponto2 = new Ponto {X=1,Y=1 };
            Ponto copiaPonto2 = ponto2;
            ponto2.X = 3;
            Console.WriteLine( "valor de ponto2 é: {0}", ponto2.X);
            Console.WriteLine("valor de copia ponto2 é {0}", copiaPonto2.X);// Por referencia 

        }
    }
}
