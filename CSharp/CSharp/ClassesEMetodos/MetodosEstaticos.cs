using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ClassesEMetodos
{

    public class CalculadoraEstatica
    {
        public static int Multiplicar(int a, int b) { //static acessivel a partir da classe
            return a * b; //uma unica copia
        }

        public int Somar(int a, int b) { //esse atributo quando instanciado tem mais de uma copia 
            return a + b;
        }
    }
    internal class MetodosEstaticos
    {
        public static void Executar() {

            CalculadoraEstatica calc = new CalculadoraEstatica();
            var resultado = calc.Somar(10, 15);
            Console.WriteLine("O valor da Soma é de {0}", resultado);

            var resultado1 = CalculadoraEstatica.Multiplicar(10, 3);
            Console.WriteLine("Valor da multiplicação: {0}", resultado1);
        }
    }
}
