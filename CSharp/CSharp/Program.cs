using System;
using System.Collections.Generic;
using CSharp.EstruturaDeControle;
using CSharp.Fundamentos;
using CSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConsta.Executar },
                {"Inferencia - Fundamentos", Inferencia.Executar },
                {"Interpolacao - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendos Dados - Fundamentos", LendoDados.Executar },
                {"FormatandoNumeros - Fundamentos", FormatandoNumeros.Executar },
                {"Conversoes - Fundamentos", Conversoes.Executar },
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores Atribuição - Fundamentos", OperadorDeAtribuicao.Executar },
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar },
                {"Operadores Ternario - Fundamentos", OperadorTernario.Executar },

                //Estruturas de Controle
                {"Estrutura IF - Estrutura de controle", EstruturaIf.Executar },
                {"Estrutura IF/else - Estrutura de controle", EstruturaIfElse.Executar },
                {"Estrutura IF/else/If - Estrutura de controle", EstruturaIfElseIf.Executar },
                {"Estrutura Switch - Estrutura de controle", EstruturaSwitch.Executar },
                {"Estrutura While - Estrutura de controle", EstruturaWhile.Executar },
                {"Estrutura Do While - Estrutura de controle", EstruturaDoWhile.Executar },
                {"Estrutura For - Estrutura de controle", EstruturaFor.Executar },
                {"Estrutura For Each - Estrutura de controle", EstruturaForEach.Executar },
                {"Estrutura Break - Estrutura de controle", UsandoBreak.Executar },
                
                
                //Classes e Métodos
                {"Membros - Classes e Metodos", Membros.Executar },
                {"Construtores - Classes e Metodos", Construtores.Executar },
                {"Métodos com Retorno - Classes e Metodos", MetodosComRetorno.Executar },
                {"Métodos Estáticos - Classes e Metodos", MetodosEstaticos.Executar },
                {"Atributos Estáticos - Classes e Metodos", AtributosEstaticos.Executar },
                {"Desafio Atributos - Classes e Metodos", DesafioAtributos.Executar },
                {"Params - Classes e Metodos", Params.Executar },
                

            });

            central.SelecionarEExecutar();
        }
    }
}