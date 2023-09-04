using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class VariaveisEConstantes {
        public static void Executar() {
            // Area da circunferencia 
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Area é " + (area + 1000));

            // tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo" + estaChovendo);

            byte idade = 45; // byte so aceita valor positivo 
            Console.WriteLine("Idade" + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols" +saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário" + salario); 

            int menorValor = int.MinValue; //Mais usado dos inteiro !

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira" + populacaoBrasileira);
            
            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long" + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("população mundial" + populacaoMundial);

            float precoComputador = 1299.99F;
            Console.WriteLine("Preço do Computador" + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor da Apple" + valorDeMercadoDaApple);

            decimal DistanciaMaximaDasEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia é" + DistanciaMaximaDasEstrelas);

            char letra = 'd';

            string texto = "Seja bem vindo ao curso de C#";
        }
    }
}
