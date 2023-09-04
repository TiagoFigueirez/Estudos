using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesQuenue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beutrano");

            Console.WriteLine(fila.Peek());//tirar o primeiro item da lista e exibe 
            Console.WriteLine(fila.Count());//mostra todos os elementos da lista
            Console.WriteLine(fila.Dequeue());//tira o primeiro da lista 
            Console.WriteLine(fila.Contains("fulano"));//mosta se esse item existe retornar booleano

            foreach (var pessoa in fila) 
            {
                Console.WriteLine(pessoa);
            }
            var salada = new Queue();//esse não usa generics como set podemos colocar varios tipos 
        }
    }
}
