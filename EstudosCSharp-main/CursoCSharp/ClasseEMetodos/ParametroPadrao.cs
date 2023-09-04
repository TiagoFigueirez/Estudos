using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseEMetodos
{
    internal class ParametroPadrao
    {
        public static int Somar(int num1=1, int num2=1)
        {
            return num1+ num2;
        }
        public static void Executar()
        {
            Console.WriteLine(Somar(23,55));
            Console.WriteLine(Somar(55, 60));
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(80));

        }
    }
}
