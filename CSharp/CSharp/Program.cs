using System;
using System.Collections.Generic;

using CSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConsta.Executar },
                {"Inferencia - Fundamentos", Inferencia.Executar },
                {"Interpolacao - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendos Dados - Fundamentos", LendoDados.Executar },
                {"FormatandoNumeros - Fundamentos", FormatandoNumeros.Executar },
                {"Conversoes - Fundamentos", Conversoes.Executar },

            });

            central.SelecionarEExecutar();
        }
    }
}