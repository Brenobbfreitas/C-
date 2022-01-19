using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ClassesEMetodos
{
    internal class Params
    {

        public static void Recepicionar(params string[] pessoas) { //todos os arugmesntos vão ser armazenados em pessoas
            foreach (var pessoa in pessoas) { //pessoas. nome do parametro recebido
                Console.WriteLine("olá {0}",pessoa);
            }
        }
        public static void Executar() {
            Recepicionar("ANA", "MAJU", "KARLA", "DISGRAMA");
        }
    }
}
