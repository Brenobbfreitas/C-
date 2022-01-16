using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.EstruturaDeControle
{
    internal class EstruturaFor
    {
        public static void Executar() {
            //for(int i = 1; i < 10; i++) {
            //    Console.WriteLine($"O valor de i é {i}");
            //}

            double somatorio = 0;
            string entrada;

            Console.WriteLine("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoDaTurma);

            for(int i = 1; i <= tamanhoDaTurma; i++) {
                Console.Write("Informe a nota do aluno {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAluno);

                somatorio += notaAluno;
            }

            double media = tamanhoDaTurma > 0 ? somatorio / tamanhoDaTurma : 0;
            Console.WriteLine("A media da Turma: {0}", media);

        }
    }
}
