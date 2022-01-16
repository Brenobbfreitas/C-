using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.EstruturaDeControle
{
    internal class EstruturaWhile
    {
        public static void Executar() {
            int palpite = 0;
            Random random = new Random(); //valor aleatorio gerado

            int numeroSecreto = random.Next(1, 16); // intervalos
            bool numeroEncontrado = false;
            int tentativaRestante = 5;

            int tentativasAtuais = 0;


            while (tentativaRestante > 0 && !numeroEncontrado) {
                Console.WriteLine("Insira seu palpite");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativasAtuais++;
                tentativaRestante--;

                if (numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero encontrado em {0} tentativas", tentativasAtuais);
                    Console.BackgroundColor = corAnterior;
                }else if(palpite > numeroSecreto) {
                    Console.WriteLine("Menor... Tente novamente!");
                    Console.WriteLine("Tentativas Restantes: {0}", tentativaRestante);
                }
                else {
                    Console.WriteLine("Maior... Tente Novamente");
                    Console.WriteLine("Tentativas Restantes: {0}", tentativaRestante);
                }
            }
        }
    }
}
