using CursoCSharp.api;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.Excecoes;
using CursoCSharp.Fundamentos;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.OO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() { 
            
              // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis e constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"Notacao ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados - Fundamentos", LendoDados.Executar},
                {"FormatandoNumero - Fundamentos", FormatandoNumero.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuicao - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternario - Fundamentos", OperadorTernario.Executar},

                //Estruturas de controle

                {"Estrutura If - Estrutura de controle", EstruturaIf.Executar},
                {"Estrutura IfElse - Estrutura de controle", EstruturaIfElse.Executar},
                {"Estrutura ifElseIf - Estrutura de controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estrutura de controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estrutura de controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estrutura de controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estrutura de controle", EstruturaFor.Executar},
                {"Estrutura ForEach - Estrutura de controle", EstruturaForEach.Executar},

                //Classes E Metodos
                {"Membros - Classes e métodos", Membros.Executar},
                {"Construtores - Classes e métodos", Construtores.Executar},
                {"MetodosComRetorno - Classes e métodos", MetodosComRetorno.Executar},
                {"MetodosEstaticos - Classes e métodos", MetodosEstaticos.Executar},
                {"AtributosEstaticos - Classes e métodos", AtributosEstaticos.Executar},
                {"DesafioAtributo - Classes e métodos", DesafioAtributo.Executar},
                {"Params - Classes e métodos", Params.Executar},
                {"ParametrosNomeados - Classes e métodos", ParametrosNomeados.Executar},
                {"GetSet - Classes e métodos", GetSet.Executar},
                {"Props - Classes e métodos", Props.Executar},
                {"Readonly - Classes e métodos", Readonly.Executar},
                {"ExemploEnum - Classes e métodos", ExemploEnum.Executar},
                {"Struct - Classes e métodos", ExemploStruct.Executar},
                {"StructVsClasse - Classes e métodos", StructVsClasse.Executar},
                {"ValorVsReferencia - Classes e métodos", ValorVsReferencia.Executar},
                {"ParametrosPorReferencia - Classes e métodos", ParametrosPorReferencia.Executar},
                {"Parametro com valor padrão - Classes e métodos", ParametroPadrao.Executar},

                //Colecoes
                {"ColecoesArray - Colecoes", ColecoesArray.Executar},
                {"ColecoesList - Colecoes", ColecoesList.Executar},
                {"ColecoesArrayList - Colecoes", ColecoesArrayList.Executar},
                {"ColecoesSet - Colecoes", ColecoesSet.Executar},
                {"ColecoesQueue - Colecoes", ColecoesQueue.Executar},
                {"Igualdade - Colecoes", Igualdade.Executar},
                {"ColecoesStack - Colecoes", ColecoesStack.Executar},
                {"ColecoesDictionary - Colecoes", ColecoesDictionary.Executar},

                // OO
                {"Heranca - OO", Heranca.Executar},
                {"ConstrutorThis - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},

                {"ExemploLambda - MetodosEFuncoes", ExemploLambda.Executar},
                {"LambdasDelegate - MetodosEFuncoes", LambdasDelegate.Executar},
                {"UsandoDelegate - MetodosEFuncoes", UsandoDelegate.Executar},
                {"DelegateFuncAnonima - MetodosEFuncoes", DelegateFuncAnonima.Executar},
                {"DelegatesComParametros - MetodosEFuncoes", DelegatesComParametros.Executar},
                {"MetodosDeExtensao - MetodosEFuncoes", MetodosDeExtensao.Executar},

                // Excecoes
                {"PrimeiraExcecao - Excecoes", PrimeiraExcecao.Executar},
                {"ExcecoesPersonalizadas - Excecoes", ExcecoesPersonalizadas.Executar},

                // API
                {"PrimeiroArquivo - Usando API", PrimeiroArquivo.Executar},
                {"LendoArquivos - Usando API", LendoArquivos.Executar},
                {"ExemploFileInfo - Usando API", ExemploFileInfo.Executar},
                {"Diretorios - Usando API", Diretorios.Executar},
                {"ExemploDirectoryInfo - Usando API", ExemploDirectoryInfo.Executar},
                {"ExemploPath - Usando API", ExemploPath.Executar},
                {"ExemploDateTime - Usando API", ExemploDateTime.Executar},
                {"ExemploTimeSpan - Usando API", ExemploTimeSpan.Executar},

            });



            central.SelecionarEExecutar();
        }
    }
}
