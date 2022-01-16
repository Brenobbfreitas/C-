using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Fundamentos
{
    internal class OperadoresUnarios
    {
        public static void Executar() {

            var valorNegativo = -5;
            var num1 = 2;
            var num2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);

            num1++; //pós 
            Console.WriteLine(num1);

            --num1; //antes
            Console.WriteLine(num1);

            Console.WriteLine(num1++ == --num2);
            Console.WriteLine($"{num1} {num2}");
        }
    }
}
