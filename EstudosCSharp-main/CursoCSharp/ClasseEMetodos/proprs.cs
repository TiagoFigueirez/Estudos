using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseEMetodos
{
    public class CarroOpicional
    {
        double desconto = 0.1;
        string nome;

        public string Nome// propriedade publica que get e set no atributo nome
        {
            get 
            {
                return "opcional:" + nome; //retorna opicional por que atribui e seta no atributo nome
             
            }
            set
            {
                nome= value;//recebe o valor pegado em get por isso value
            }

        }
        //propriedade autoimplementada coloco apenas caro.preco e acesso ele
        public double Preco { get; set; }
        //propriedades que apenas le o dado com o metodo get
        public double PrecoComDesconto
        {
            get
            {
                return Preco - (desconto * Preco);
            }
        }

        public CarroOpicional()
        {

        }
        public CarroOpicional(string nome,double preco)
        {
            Nome = nome;
            Preco = preco;
        }


    }
    internal class proprs
    {
        public static void Executar()
        {
            var op1 =new CarroOpicional("Ar Condicionado",3600.9);
            Console.WriteLine(op1.PrecoComDesconto);

            var op2 = new CarroOpicional();
            op2.Nome = "Direcção eletrica";
            op2.Preco = 2600.0;
            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);
            

        }
    }
}
