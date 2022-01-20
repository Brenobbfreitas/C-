using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ClassesEMetodos
{

    public struct SPonto
    {
        public int X;
        public int Y;
    }

    public class CPonto
    {
        public int X;
        public int Y;
    }

    //diferença entre struct e classe
    internal class StructVsClasse
    {
        public static void Executar() { //struct a atribuição é feita por valor e não por referencia
            SPonto ponto1 = new SPonto { X = 1, Y = 2, };
            SPonto copiaPonto1 = ponto1; //atribuição por valor
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 X:{0}", ponto1.X);
            Console.WriteLine("Copia Ponto 1 X:{0}", copiaPonto1.X);

            CPonto ponto2 = new CPonto { X = 2, Y = 4, };// classe a atribuição é feita por referencia
            CPonto copiaPonto2 = ponto2;
            ponto2.X = 3;

            Console.WriteLine("Ponto 2 X:{0}", ponto2.X);
            Console.WriteLine("Copia Ponto 2 X:{0}", copiaPonto2.X);
        }
    }
}
