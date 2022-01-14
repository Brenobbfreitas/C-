using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Fundamentos
{
    internal class Inferencia //ele infere o tipo da variavel 
    {
        public static void Executar() {
            var nome = "Leonardo";
            Console.WriteLine(nome);

            var idade = 20; // para q a inferencia seja feita é preciso iniciar a variavel
            Console.WriteLine(idade);
        }
    }
}
