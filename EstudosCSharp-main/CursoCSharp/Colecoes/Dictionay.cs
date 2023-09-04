using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Dictionay
    {
        public static void Executar()
        {
            var Filmes = new Dictionary<int, string>();// aceita repetição na string mas não na chave

            Filmes.Add(2000, "Gladiador");
            Filmes.Add(2002, "Homem Aranha");
            Filmes.Add(2004, "Os Incriveis");
            Filmes.Add(2006, "O grande Truque");

            if (Filmes.ContainsKey(2004))// vai pegar o valor que eu passei e verificar se tem na coluna das chaves
            {
                Console.WriteLine("2004 " + Filmes[2004]);// assim que pega o valor da chave
                Console.WriteLine("2004 " + Filmes.GetValueOrDefault(2008));
                //faz a mesma coisa mas caso o numero passado seja diferente retorna uma string vazia
            }
            Console.WriteLine(Filmes.ContainsValue("Aminésia"));// outra forma de verifica se existe o valor passado

            Console.WriteLine($"Removeu {Filmes.Remove(2004)}?" );

            Filmes.TryGetValue(2006, out string filme2006);//pega o valor que vc tenteou pegar e joga em uma variavel
            Console.WriteLine($"Filme {filme2006}");

            foreach(var chave in Filmes.Keys)//percorrer as chaves
            {
                Console.WriteLine(chave);
            }
            foreach(var valores in Filmes.Values) //percorrer valores
            { 
                Console.WriteLine(valores);
            }
            foreach(KeyValuePair<int, string> filme in Filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");//mostra os dois valores
            }
            //outra forma de fazer a mesma coisa 
            foreach(var filme in Filmes)
            {
                Console.WriteLine($"{filme.Value} e de {filme.Key}");
            }

        }
    }
}
