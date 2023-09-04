using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Array
    {
        public static void Executar()
        {
            string[] Alunos = new string [5];//declaração de um array e homogeneo e um tamanho fixo 
            //so aceita um tipo de dado

            //acessar um item do array pelo indice
            Alunos[0] = "Anderson";
            Alunos[1] = "Sara";
            Alunos[2] = "Julio";
            Alunos[3] = "Maria";
            Alunos[4] = "Jeferson";

            foreach(var aluno in Alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;

            double[] notas = { 9.8, 8.0, 7.5, 9.0, 7.5 }; // array de numeros 

            foreach(var Nota in notas)
            {
                somatorio += Nota;
            }

            //for(int i= 0; i< notas.Length; i++)//outra forma de fazer o laço 
            //{
            //    somatorio += notas[i];
            //}

            double media = somatorio / notas.Length;// Length divide pelo numero de

            Console.WriteLine(media);

            char[] letras = { 'A', 'R', 'R', 'Y' };//array de letras
            string palavra = new string(letras);
            Console.WriteLine(palavra);

        }
    }
}
