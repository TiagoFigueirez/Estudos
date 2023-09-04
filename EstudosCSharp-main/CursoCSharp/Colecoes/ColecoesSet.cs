using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesSet
    {
        public static void Executar()
        {
            var Livro = new produto("Game pf Thrones", 49.99);

            var carrinho = new HashSet<produto>();  
            carrinho.Add(Livro);
            var combo = new HashSet<produto>()
            {
                new produto("camisa",29.90),
                new produto("8 temporada",80.00),
                new produto("caneca",17.90)
            };

            carrinho.UnionWith(combo);//esse e o comando para adicionar itens 
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3); com set n e possivel mais remover itens por esse comando

            foreach (var item in carrinho)
            {
                //Console.Write(carrinho.IndexOf(item));não e possivel usar indexof
                Console.WriteLine($" {item.Nome}{item.Preco}");//não permite repetir itens
            }

        }
    }
}
