using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ClassesEMetodos
{
    public class CalculadoraComum
    {
        public int Somar(int a, int b) { //metodo
            return a + b;
        }
        public int Subtrair(int a, int b) { //metodo
            return a - b;
        }

        public int Multiplicar(int a, int b) {
            return (a * b);
        }
    }

    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this; //instancia atual que estou trabalhando. retorna o proprio objeto
        }

        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado() {
            return memoria;
        }
    }
        internal class MetodosComRetorno
        {
            public static void Executar() {
                var calculadoraComun = new CalculadoraComum();
                var resultado = calculadoraComun.Somar(5, 2);

                Console.WriteLine(resultado);
                Console.WriteLine(calculadoraComun.Subtrair(9, 5));
                Console.WriteLine(calculadoraComun.Multiplicar(9, 6));


                var calculadoraCadeia = new CalculadoraCadeia();
                calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();


                resultado = calculadoraCadeia.Somar(3).Multiplicar(4).Resultado();
                Console.WriteLine(resultado);

            
            }
    }
}
