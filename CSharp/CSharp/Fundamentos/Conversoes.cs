using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace CSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.6;
            int notaTruncada = (int) nota;
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Sua idade é de {0}",idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);


            Console.WriteLine("Digite um valor: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1); //metodo mais segura 
            Console.WriteLine("Resultado 1: {0}",numero1);

            Console.WriteLine("Digite o segundo valor: ");
            int.TryParse(Console.ReadLine(), out int numero2); //metodo otimizado
            Console.WriteLine("Resultado 2: {0}", numero2);
        }
    }
}
