using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharp.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar() {
            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine()); //Parse ->converte a entrada para ineiro

            Console.WriteLine("Qual é o seu salário");
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine($"olá {nome}, sua idade é de: {idade} e salário: {salario}");

            int inteiro = 145;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
