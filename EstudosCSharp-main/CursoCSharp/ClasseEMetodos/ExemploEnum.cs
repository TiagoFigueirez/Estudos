using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseEMetodos
{
    internal class ExemploEnum
    {
        public enum Genero { Acao, Aventura , Terror , Animacao, Comedia};//enum enumrera alguns itens do 0 em diante
        //no caso acao e 1 e comedia e o 3

        public class filme
        {
            public string Titulo;
            public Genero GeneroDoFilme;
        }
        public static void Executar()
        {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var FilmeParaAFamilia = new filme();
            FilmeParaAFamilia.Titulo = "Sharkinado 17";
            FilmeParaAFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine("O {0} é {1}",FilmeParaAFamilia.Titulo,FilmeParaAFamilia.GeneroDoFilme);
        }
    }
}
