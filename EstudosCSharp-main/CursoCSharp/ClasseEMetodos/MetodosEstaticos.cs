using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseEMetodos
{

    public class CauculadoraEstatica
    {
        public static int somar(int a, int b)
        { 
            return a + b;
        }

        public static int multiplicar(int a, int b) 
        {
           return a* b;
        }

    }
    internal class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CauculadoraEstatica.somar(2,2);//metodos estaticos não precisam ser instanciados
            //intacia vc declara um novo onjeto com um novo nome exemplo pessoa ana= new pessoa ja estatico todos
            //tem o mesmo nome
            Console.WriteLine("resultado: {0}", resultado);

            Console.WriteLine(CauculadoraEstatica.multiplicar(2,2));

        }
    }
}
