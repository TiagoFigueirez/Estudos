using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseEMetodos {

    class Carro {
        public string marca;
        public string modelo;
        public int ano;

        public Carro(string Marca, string Modelo, int Ano) { 
            marca= Marca;
            modelo= Modelo;
            ano= Ano;   
        }

        public Carro() {

        }
    }
    internal class Construtores {

        public static void Executar() {

            var carro1 = new Carro();// não funciona sem um construtor vazio
            carro1.marca = "BMW";
            carro1.modelo = "325i";
            carro1.ano = 2017;
            Console.WriteLine($"{carro1.marca} {carro1.modelo} {carro1.ano}");

            var carro2 = new Carro("Ford", "Ka", 2019);  
                Console.WriteLine($"{carro2.marca} {carro2.modelo} {carro1.ano}");
        

        }
    }
}
