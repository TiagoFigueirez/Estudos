using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaFor {

        static public void Executar() {

            //for(int i =1; i <10; i++) {
            //  Console.WriteLine("valor de i é {0}", i);

            double somatorio = 0;
            string entrada;

            Console.WriteLine("informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int TamanhoTurma);

            for(int i = 1;i<= TamanhoTurma; i++) {
                Console.Write("insira a nota do aluno {0}:", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }
            double media = TamanhoTurma > 0 ? somatorio / TamanhoTurma :0;

            Console.WriteLine("Media da Turma {0}",media);
            }
        }
    }

