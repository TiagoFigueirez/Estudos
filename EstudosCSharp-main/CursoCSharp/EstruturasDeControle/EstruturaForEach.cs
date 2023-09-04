using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaForEach {

        static public void Executar() {

            var aluno = new string[] { "ana", "sara", "maria" };

            foreach (string alunos in aluno) {
                Console.WriteLine(alunos);
            }

        }
    }
}
