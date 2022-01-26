using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Colecoes
{
    internal class Arrays
    {
        public static void Executar() {
            string[] alunos = new string[5];
            alunos[0] = "Carlos";
            alunos[1] = "Breno";
            alunos[2] = "Daniel";
            alunos[3] = "Carol";
            alunos[4] = "Vania";

            foreach (string s in alunos) {
                Console.WriteLine(s);
            }

            double somatorio = 0;
            double[] notas = { 9.4,7.8,9.8,6.7};

            foreach (var nota in notas) {
                somatorio += nota;
            }

            for(int i = 0; i < notas.Length; i++) {
                var valor = notas[i];
                Console.WriteLine($"SUA NOTA:{valor}");
            }

            double media = somatorio / notas.Length;
            Console.WriteLine($"SUA MEDIA ESCOLAR:{media}");

            char[] letras = {'A', 'B', 'C', 'D', 'E' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
