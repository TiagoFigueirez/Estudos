using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseEMetodos
{
    internal class AtributVsRef
    {
        public struct Dependente
        {
            public string NOME;
            public int IDADE;
            
        }
        public static void Executar()
        {
            int numero = 3;
            int CopiaNumero = numero;
            Console.WriteLine("{0}, {1}",numero,CopiaNumero);

            numero++;
            Console.WriteLine("{0}, {1}", numero, CopiaNumero);

            Dependente Dep=new Dependente
            {
                NOME="Beto",
                IDADE=25
            };

            Dependente CopiaDep = Dep;

            Console.WriteLine("{0},{1}",Dep.NOME,Dep.IDADE);
            Console.WriteLine("{0},{1}",CopiaDep.NOME,CopiaDep.IDADE);

            CopiaDep.NOME = "Renato";
            CopiaDep.IDADE = 30;
            Console.WriteLine("{0},{1}", CopiaDep.NOME, Dep.NOME);
            Console.WriteLine("{0},{1}", CopiaDep.IDADE, Dep.IDADE);

        }
    }
}
