using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Igualdade
    {
        public static void Executar()
        {
            var p1 = new produto("caneta", 1.50);
            var p2 = new produto("caneta", 1.50);
            var p3 = p2;

            //apontam para 2 espaços de memoria diferente
            Console.WriteLine(p1==p2);
            Console.WriteLine(p3==p2);//true pq apontam pro msm local de memoria 

            Console.WriteLine(p1.Equals(p2));//tbn compara enderço de memoria

    }

    }
}
