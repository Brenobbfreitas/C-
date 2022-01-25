using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ClassesEMetodos
{
    internal class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero) {
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero) {
            numero = 0;
            numero = numero + 15;
        }
        public static void Executar() {
            int a = 3;
            AlterarRef(ref a); //chama o metodo AlterarRef e tem a referencia de numero
            Console.WriteLine(a);

            //int b; //metodo out n recebe o valor passado; ele n recebe diretamente por parametro
            AlterarOut(out int b); // menos bugs
            Console.WriteLine(b);
        }
    }
}
