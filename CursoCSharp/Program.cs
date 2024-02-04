using CursoCSharp.Fundamentos;
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
            });

            central.SelecionarEExecutar();
        }
    }
}
