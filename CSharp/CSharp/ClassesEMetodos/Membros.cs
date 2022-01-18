using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ClassesEMetodos
{
    internal class Membros
    {
        public static void Executar() {

            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Breno";
            sicrano.Idade = 23;

            //Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos!");
            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 21;

            var apresentarFulano = fulano.Apresentar();
            Console.WriteLine(apresentarFulano.Length);
            Console.WriteLine(apresentarFulano);
        }
    }
}
