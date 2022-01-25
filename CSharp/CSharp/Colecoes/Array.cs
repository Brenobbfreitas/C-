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
        }
    }
}
