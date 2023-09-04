using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseEMetodos
{

    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento; //readonly server para colocar um valor imutavel mas n precisa
                                      //colocar um valor inicial const precisa de um valor inicial 
        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }
        public string GetDataDeNascimento()
        {
            return String.Format("{0}/{1}/{2}",Nascimento.Day, Nascimento.Month, Nascimento.Year);

        }
    }
    
    internal class Readonly
    {
        public static void Executar()
        {
            var Cliente1 = new Cliente("Ana Silva", new DateTime(1984, 05, 30));

            Console.WriteLine(Cliente1.Nome);
            Console.WriteLine(Cliente1.GetDataDeNascimento());

        }
    }
}
