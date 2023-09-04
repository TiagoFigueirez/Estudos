using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClasseEMetodos;
using CursoCSharp.Colecoes;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //FUNDAMENTOS   
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar },
                {"VariaveisEConstantes" , VariaveisEConstantes.Executar},
                {"iferencia" , inferencia.Executar},
                {"InterpolacaoStrings" , InterpolacaoStrings.Executar},
                {"NotacaoPonto" , NotacaoPonto.Executar},
                {"LendoDados" , LendoDados.Executar},
                {"FormatandoNumero" , FormatandoNumero.Executar},
                {"Conversoes" , Conversoes.Executar},
                {"OperadoresAritimeticos" , OperadoresAritimeticos.Executar},
                {"OperadoresRelacionais" , OperadoresRelacionais.Executar},
                {"OperadoresLogicos" , OperadoresLogicos.Executar},
                {"OperadoresAtribuicao" , OperadoresAtribuicao.Executar},
                {"OperadoresUnarios" , OperadoresUnarios.Executar},
                {"operadorTernario" , operadorTernario.Executar},
                //Estruturas de Controle
                {"EstruturaIF" , EstruturaIF.Executar},
                {"EstrutraIfElse" , EstrutraIfElse.Executar},
                {"EstruturaIfElseIf" , EstruturaIfElseIf.Executar},
                {"EstruturaSwitch" , EstruturaSwitch.Executar},
                {"EstruturaWhile" , EstruturaWhile.Executar},
                {"EstruturaDoWhile" , EstruturaDoWhile.Executar},
                {"EstruturaFor" , EstruturaFor.Executar},
                {"EstruturaForEach" , EstruturaForEach.Executar},            
                //Classe e Metodos
                {"Membros" , Membros.Executar},
                {"Construtores" , Construtores.Executar},
                {"MetodosComRetorno" , MetodosComRetorno.Executar},
                {"MetodosEstaticos" , MetodosEstaticos.Executar},
                {"AtributosEstaticos" , AtributosEstaticos.Executar},
                {"Desafio Atributo" , DesafioAtributo.Executar},
                {"Parametros e Variaveis" , ParametrosVariaveis.Executar},
                {"Parametros Nomeados " , ParansNomeados.Executar},
                {"Get & Set " , GetSet.Executar},
                {"Propriedades " , proprs.Executar},
                {"Readonly " , Readonly.Executar},
                {"Enum " , ExemploEnum.Executar},
                {"Struct " , Struct.Executar},
                {"StructVsClasse " , StructVsClasse.Executar},
                {"Atribuição vs Referencia " , AtributVsRef.Executar},
                {"Parametros Por Referencia " , ParametrosPorReferencia.Executar},
                {"Parametros Padrâos " , ParametroPadrao.Executar},

                //Coleções
                {"Array " , Colecoes.Array.Executar},
                {"List " , ColecoesList.Executar},
                {"Array List " , ColecoesArrayList.Executar},
                {"Coleções Set " , ColecoesSet.Executar},
                {"Colecoes Quenue " , ColecoesQuenue.Executar},
                {"Igualdade " , Igualdade.Executar},
                {"Stack " , Stack.Executar},
                {"Dictionay " , Dictionay.Executar},



            });

            central.SelecionarEExecutar();
        }
    }
}