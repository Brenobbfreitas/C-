using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace CSharp.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar() {
            var saudacao = "olá ".ToUpper().Insert(3, "World!").Replace("World!", "Terra");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length); //a ? verifica a integridade da variavel; evita erros no codigo
        }
    }
}
