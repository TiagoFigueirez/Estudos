using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class NotacaoPonto {

        static public void Executar() 
        {
            string saudacao = "olá".Insert(3, "World").Replace(" World", " Mundo");


            Console.WriteLine(saudacao);

            Console.WriteLine("teste".Length);

        }
    }
}
