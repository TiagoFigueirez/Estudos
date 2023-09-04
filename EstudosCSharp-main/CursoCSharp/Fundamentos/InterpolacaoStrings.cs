using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class InterpolacaoStrings         
    {
        public static void Executar () 
        {
            string nome = "notebook gamer";
            string marca = "dell";
            double preco = 5800.00;

            Console.WriteLine("o " + nome + " da marca " + marca + " custa " + preco + ".");

            Console.WriteLine("O {0} da Marca {1} Custa {2}.", nome, marca, preco);

            Console.WriteLine($"A {marca} é legal");


        
        }


    }
}
