using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    internal class FormatandoNumero {

        static public void Executar () 
            {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));//transformar valor quebrado em inteiro
            Console.WriteLine(valor.ToString("C"));//tranforma em moeda
            Console.WriteLine(valor.ToString("P"));//tranforma em porcentagem
            Console.WriteLine(valor.ToString("#.##"));// coloca duas casa decimais a mais

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura));

            int inteiro = 256;

            Console.WriteLine(inteiro.ToString("D10"));// adiciona zeros a direita do numero 
        
        
        
        
        
        }
    }
}
