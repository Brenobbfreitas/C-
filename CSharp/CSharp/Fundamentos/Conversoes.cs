using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace CSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.6;
            int notaTruncada = (int) nota;
            Console.WriteLine("Nota truncada: {0}", notaTruncada);
        }
    }
}
