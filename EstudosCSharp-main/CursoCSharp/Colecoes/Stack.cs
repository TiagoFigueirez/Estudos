using System;
using System.Collections;
using System.Text;


namespace CursoCSharp.Colecoes
{
    internal class Stack//stack e um array que vc coloca em formato pilha
    {
        static public void Executar()
        {
            Stack<string> pilha;

            pilha = new Stack<string>();//declaração de uma pilha

            pilha.Push("tiago");//adiciona a pilha
            pilha.Push("igor ");
            pilha.Push("julio");

            foreach(var iten in pilha)
            {
                Console.WriteLine($"{iten}");
            }
            Console.WriteLine($"/nPop: {pilha.Pop()}");//pop removie um item da lista em last in first out
            foreach(var iten in pilha)
            {
                Console.WriteLine($"{iten}");
            }
            Console.WriteLine($"/nPeek: {pilha.Peek()}");// mostra o ultimo item da lista 


        }
    }
}
