using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    internal class LendoDados {

        static public void Executar() 
        {
            Console.WriteLine("Qual é o seu nome ?");
            string nome = Console.ReadLine();

            Console.WriteLine("qual e a sua idade ?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("qual e o seu salario ?");
            int salario = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            

            Console.WriteLine("nome {0}, idade {1}, salario: R$ {2}.", nome, idade, salario);
        
        
        }
    }
}
