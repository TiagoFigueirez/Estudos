using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Conversoes {

        static public void Executar() 
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int) nota;// converte mas a perda de informacao
            Console.WriteLine("nota truncada: {0}", notaTruncada);

            Console.WriteLine("Digite sua Idade:");// converter string em numero 1
            string idadeString = Console.ReadLine();
            int idadeInteiro= int.Parse(idadeString);

            Console.WriteLine("idade inserida é {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);// converter string em numero 2
            Console.WriteLine("idade é {0}", idadeInteiro );

            Console.WriteLine("digite um numero 1 :");// converter string em numero 3 (não da erro por que se nao converter o resultado e zero)
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("resultado : {0}", numero1);

            Console.WriteLine("digite um numero 2 :");// converter string em numero 4 (não da erro por que se nao converter o resultado e zero)
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("resultado : {0}", numero2);





        }
    }
}
