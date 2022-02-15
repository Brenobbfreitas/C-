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

            global::System.Console.WriteLine($"\npop: {pilha.Pop()}");
	}
}