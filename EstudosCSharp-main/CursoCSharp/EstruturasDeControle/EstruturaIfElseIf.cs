using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaIfElseIf {

        public static void Executar() {

            Console.WriteLine("digie a nota do aluno:");
            
            string entrada=Console.ReadLine();

            Double.TryParse(entrada, out double nota);

            if (nota > 9.0) {
                Console.WriteLine("quadro de honra!");

            }else if (nota >= 7.0 && nota < 9.0) {
                    Console.WriteLine("aluno aprovadp!");

            } else if(nota >=5.0&& nota <7.0){
                Console.WriteLine("recuperação");
            }else {
                Console.WriteLine("reprovado");
            }

        }
    }
}
