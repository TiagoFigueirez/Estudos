using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseEMetodos
{
    internal class DesafioAtributo
    {
        int a =10;
        static public void Executar()
        {
            DesafioAtributo mostrar =new DesafioAtributo();

            Console.WriteLine(mostrar.a);

        }
    }
}
