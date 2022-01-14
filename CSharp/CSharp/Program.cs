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

            });

            central.SelecionarEExecutar();
        }
    }
}