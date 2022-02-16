using System;
using System.Collections;

namespace CSharp.Colecoes {

	 class ColecoesStack
	{
		public static void Executar() {
			var pilha = new Stack();

			pilha.Push(3);
			pilha.Push(true);
			pilha.Push(3.14);
			pilha.Push("a");

			foreach (var item in pilha) {
                global::System.Console.WriteLine($"{item} ");
        }
			// POP remove o primeiro elemento adicionado
            global::System.Console.WriteLine($"\npop: {pilha.Pop()}");

			foreach (var item in pilha) {
				global::System.Console.WriteLine($"{item} ");
			}

			// Peek apenas pega o valor
            global::System.Console.WriteLine($"\nPeek: {pilha.Peek()}");
		}
}