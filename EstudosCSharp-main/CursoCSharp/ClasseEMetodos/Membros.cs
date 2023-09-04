using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseEMetodos {
    internal class Membros {

        static public void Executar() {

            Pessoas sicrano= new Pessoas();

            sicrano.Nome = "Renato";
            sicrano.Idade = 21;

            Console.WriteLine("nome {0}, idade {1}", sicrano.Nome, sicrano.Idade);

            Pessoas Fulano = new Pessoas();
            Fulano.Nome = "Anderson";
            Fulano.Idade = 30;

            var ApresentaçãoFulano = Fulano.Apresentar();

            Console.WriteLine();
        }
    }
}
