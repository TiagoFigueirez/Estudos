using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseEMetodos
{

    public class produto
    {
        public string nome;
        public double preco;
        public  static double desconto = 0.1; 

        public produto(string nome , double preco, double desconto) 
        {
            nome = nome;
            preco = preco;
            desconto = desconto;

        }
        public produto()
        {

        }
        public double CaucularDesconto()
        {
            return preco - preco * desconto;
        }

    }
    internal class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new produto("borracha", 5.3, 0.1);
            Console.WriteLine("valor com desconto é {0}",produto1.CaucularDesconto());

            var produto2 = new produto()
            {
                nome = "caneta",
                preco = 2.3,
                

            };
            Console.WriteLine("valor com o desconto é {0}", produto2.CaucularDesconto());

            produto.desconto = 0.5;//quando e estatico passamos o parametro assim ele será aplicado a todos 
                                  //os obijetos
        }
    }
}
