using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Fundamentos
{
    internal class VariaveisEConsta
    {
        public static void Executar() {
            //area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415;

            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            //tipos internos
            bool estaChovendo = true;
            Console.WriteLine("está chovendo "+ estaChovendo);

            byte idade = 45;// um unico byte 8 bits
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGolds = sbyte.MinValue;
            Console.WriteLine("Saldo de Golds "+ saldoDeGolds);

            short salario = short.MaxValue;
            Console.WriteLine("Salário "+ salario);

            int menorValorInt = int.MinValue;// mais usado dos inteiros
            Console.WriteLine("Menor int "+ menorValorInt);

            uint populacaoBrasileira = 207_600_000; //valor sem sinal uint
            Console.WriteLine("População Brasileira "+ populacaoBrasileira);

            long menorValorLong= long.MinValue;
            Console.WriteLine("Menor Long "+ menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial "+ populacaoMundial); // sem valor negativo

            float precoComputador = 1288.99f; // valores de ponto flutuante adicioar o F
            Console.WriteLine("Preço Computador "+ precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine("valor da apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre Estrelas "+ distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra "+letra);

            string texto = "qualquer coisa";
            Console.WriteLine("texto: "+ texto);
        }
    }
}
