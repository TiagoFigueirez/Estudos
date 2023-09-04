using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresAritimeticos {

        static public void Executar() 
            {

            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = imposto + preco;

            var TotalComDesconto = total - total*desconto;

            Console.WriteLine(TotalComDesconto);

            double peso = 80;
            double altura = 1.73;
            double imc = peso / (altura * altura);

            Console.WriteLine("Imc é {0}", imc);
        
        
        
        }
    }
}
