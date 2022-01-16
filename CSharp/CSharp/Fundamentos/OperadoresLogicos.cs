using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Fundamentos
{
    internal class OperadoresLogicos
    {
        public static void Executar() {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTV50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou TV 50 ? {0}", comprouTV50);
            
            var sorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou sorvete ? {0}", sorvete);
            
            var comprouTV32 = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou comprou TV32 ? {0}", comprouTV32);

            Console.WriteLine("Mais saudavel ? {0}", !sorvete);

        }
    }
}
