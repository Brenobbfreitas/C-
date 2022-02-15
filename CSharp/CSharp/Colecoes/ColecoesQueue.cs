using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar() {
            var fila = new Queue<string>();
            //metodo para adicionar coisa na fila  
            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            ///retorna o primeiro elemento da Fila
            Console.WriteLine(fila.Peek());
            ///retorna o Tamanho da fila
            Console.WriteLine(fila.Count());
            ///tira a primeira pessoa da Fila
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count());

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("item");
            salada.Enqueue(true);
            salada.Enqueue(3.123);

            //metodo para verificar a fila
            Console.WriteLine(salada.Contains("item"));
        }
    }
}