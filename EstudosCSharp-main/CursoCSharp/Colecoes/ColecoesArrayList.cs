using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesArrayList
    {
        public static void Executar()
        {
            var ArrayList = new ArrayList//dece-se tirar o generic do collections 
            {
                "palavra",
                3,
                true
            };

            ArrayList.Add(14.4);//adiciona dados ao ArrayList

            foreach (var item in ArrayList)
            {
                Console.WriteLine("{0}, {1}",item, item.GetType()); //get type traz o tipo do item
            }
        }
    }
}
