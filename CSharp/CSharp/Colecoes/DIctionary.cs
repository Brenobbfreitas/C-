using System;

namespace CSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar() {

            
            var filmes = new Dictionary<int, string>

                filmes.Add(2000, "Gladiador");
                filmes.Add(2002, "Miranha");
                filmes.Add(2004, "Os Incriveis");
                filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004)) {
                global::System.Console.WriteLine("2004: " + filmes[2004]);
                // metodo busca o valor no Dictionary de filmes
                global::System.Console.WriteLine("2004 "+ filmes.GetValueOrDefault(2008));
            }
            // percorre filmes atrás do valor "Amnésia"
            global::System.Console.WriteLine(filmes.ContainsValue("Amnésia"));
            // remove valor
            global::System.Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            filmes.TryGetValue(2006, out string filmes2006);
            global::System.Console.WriteLine($"Filmes {filmes2006}!");

            ///formas de percorrer o dictionary
            /// valor do inidice
            foreach (var chave in filmes.Keys) {
                global::System.Console.WriteLine(chave);
            }
            // valor da item
            foreach (var valor in filmes.Values) {
                global::System.Console.WriteLine(valor);
            }

            foreach (KeyValuePari<int, string> filme in filmes) {
                global::System.Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }

            foreach (var filme in filmes) {
                global::System.Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }
        }
    }
}
