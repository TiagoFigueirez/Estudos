using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseEMetodos
{
    internal class ParametrosVariaveis
    {
        static public void recepcionar(params string [] pessoas)//armazena todos os nomes no array pessoas
        {
            foreach (var pessoa in pessoas) 
            {
                Console.WriteLine("Ola {0}",pessoa);//imprimi os nomes ate o fim da array
            }
        }
        static public void Executar()
        {
            recepcionar("leo", "pedro", "ana", "julio");

        }
    }
}
