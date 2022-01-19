using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ClassesEMetodos
{

    public enum Genero {Acao, Aventura, Terror, Animacao, Comedia };

    public class Filme
    {
        public string Titulo;
        public Genero GeneroFilmes;
    }
    internal class Enumeracoes
    {
        public static void Executar() {
            int id = (int)Genero.Animacao; //convertendo enum para inteiro
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Sharknardo 18";
            filmeParaFamilia.GeneroFilmes = Genero.Comedia;

            Console.WriteLine("{0} é {1}", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroFilmes);
        }
    }
}
