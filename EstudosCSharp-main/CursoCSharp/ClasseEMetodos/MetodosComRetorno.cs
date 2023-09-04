using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseEMetodos {

    class CauculadoraComum {

        public int Somar(int a, int b) {

            return a + b;

        }

        public int Subtrair(int a, int b) { 
            
            return a - b; 
        
        }


     

    }
    class CauculadoraCadeia {

        int memoria;

        public CauculadoraCadeia somar(int a) {

            memoria += a;

            return this;

        }
        public CauculadoraCadeia multiplicar(int a) {

            memoria *= a;

            return this;

        }
        public CauculadoraCadeia limpar(int a) {

            memoria = 0;

            return this;

        }
        public CauculadoraCadeia imprimir() {

            Console.WriteLine(memoria);

            return this;

        }
        public int Resultado() {

            return memoria;
        }
    }

    internal class MetodosComRetorno {
        static public void Executar() {

            var cauculadoraComum = new CauculadoraComum();

            var resultado = cauculadoraComum.Somar(1, 2);
            Console.WriteLine(resultado);

            Console.WriteLine(cauculadoraComum.Subtrair(4, 5));

            var cauculadoraCadeia = new CauculadoraCadeia();

            cauculadoraCadeia.somar(3).multiplicar(2).imprimir();

        }
    }
}
