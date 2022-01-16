using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Fundamentos
{
    internal class OperadorTernario
    {
        public static void Executar() {
            var nota = 7.0;
            var resultado = nota >= 7 ? "Aprovado" : "Reprovado"; // verifica -> verdade : Falso
            Console.WriteLine(resultado);
        }
    }
}
