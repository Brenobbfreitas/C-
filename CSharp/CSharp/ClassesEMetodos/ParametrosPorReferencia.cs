using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ClassesEMetodos
{
    internal class ParametrosPorReferencia
    {
        public static void AlterarRef(int numero) {
            numero = numero + 1000;
        }

        public static void AlterarOut(int numero) {
            numero = numero + 15;
        }
        public static void Executar() {
            int a = 3;
            AlterarOut(a);
            Console.WriteLine(a);

            int b = 2;
            AlterarOut(b);
            Console.WriteLine(b);
        }
    }
}
