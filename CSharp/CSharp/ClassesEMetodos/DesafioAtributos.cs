using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ClassesEMetodos
{
    internal class DesafioAtributos
    {

        // static int a = 10;

        int A = 10;

        public static void Executar() {

            //Acessar a variável 'a' dentro do metodo Executar!
            //console.writeline(a)

            var Letra1 = new DesafioAtributos();
            Console.WriteLine(Letra1.A);
        }
    }
}
