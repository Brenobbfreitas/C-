using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ClassesEMetodos
{
    interface Ponto
    {
        void MoverNaDiagonal(int delta); //assinatura da função
    }

    struct Coordenada: Ponto{
        public int X;
        public int Y;

        public Coordenada(int x, int y) { //Construtor
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta) { //Metodo
            X += delta;
            Y += delta;
        }
    }
    internal class ExemploStruct //suporta o uso de interface 
    {
        public static void Executar() {
            Coordenada coordenadaInicial; //variavel Coordenada definida 
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("Coordenada Inicial: ");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("Y = {0}",coordenadaInicial.Y);

            var coordenadaFinal = new Coordenada(x: 9,y: 1);

            coordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada Final:");
            Console.WriteLine("X = {0}", coordenadaFinal.X);
            Console.WriteLine("Y = {0}", coordenadaFinal.Y);

        }
    }
}
