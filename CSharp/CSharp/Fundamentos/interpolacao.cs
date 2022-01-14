using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Fundamentos
{
    internal class Interpolacao
    {
         public static void Executar() {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 1000.00;

            Console.WriteLine("Comprei um "+nome+" de marca "+marca+" no valor de :"+preco+".");
            Console.WriteLine("O {0} de marca {1} custou {2}", nome, marca, preco);
            Console.WriteLine($"Os {nome} são muito poderosos");
        }
    }
}
