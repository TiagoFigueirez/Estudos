using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseEMetodos
{
    internal class ParansNomeados
    {
        public static void Formatar(int dia, int mes , int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2:D2}", dia, mes, ano);
        }
        public static void Executar()
        {
            Formatar(ano: 1998, dia: 22, mes: 1);// a ordem dos parametros não importa por que ele identifica
                                                 //pela nomeação
        }
    }
}
