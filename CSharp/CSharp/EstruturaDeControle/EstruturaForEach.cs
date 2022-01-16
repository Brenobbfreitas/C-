using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.EstruturaDeControle
{
    internal class EstruturaForEach
    {
        public static void Executar() {
            var palavra = "Opa!";

            foreach (var letra in palavra) //percorre a variavel palavra e atribui na var letra
                {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Ana", "bia", "Carlos" }; //array 
            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }
        }
    }
}
