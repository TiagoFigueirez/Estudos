using CursoCSharp.Fundamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseEMetodos
{
    internal class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero = numero + 1000;
        }

        public static void AlterarOut( out int numero1, out int numero2)
        {
            numero1 = 0;
            numero2 = 0;
            numero1 = numero1 + 15;
            numero2 = numero2 + 30;
        }
        public static void Executar()
        {
            int a = 3;

            AlterarRef(ref a); //nesse caso passo que a referencia a variavel int numero e ai ele muda o valor

            Console.WriteLine(a);

            //int b = 3;

            AlterarOut(out int b, out int c);
            Console.WriteLine("{0} {1}",b,c);//com out podemos retonrar 2 valores na função 

        }
    }
}
