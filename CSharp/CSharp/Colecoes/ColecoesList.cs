using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;


        /// <summary>
        /// construtor
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="preco"></param>
        public Produto(string nome, double preco) {
            {
                this.Nome = nome;
                this.Preco = preco;
            }


            /// faz uma filtragem de para o Equals, performatico
            public override int GetHashCode() {
            return Nome.Length;
        }

        public override bool Equals(object? obj) {
            Produto outroProduto = (Produto)obj;
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;
            return mesmoNome && mesmoPreco;
        }
    }
    
    class ColecoesList
    {
        public static void Executar() {
                var livro = new Produto("Gatilho", 78.99);


                var carrinho = new List<Produto>();
                carrinho.Add(livro);
                /// O list é uma estrutura indexada
                var combo = new List<Produto>() {
                    new Produto("Camisa", 29.90),
                    new Produto("8 Temporada Aflex", 65.69),
                    new Produto("Shots", 52.55)
                }
                ///metodo para adicionar conteudo de uma lista dentro de outro
                carrinho.AddRange(combo);
                console.WriteLine(carrinho.Count);//verifica tamanho da linha
                carrinho.RemoveAt(3); //remover o elemento de indice 3 


                foreach (var item in carrinho) {
                    global::System.Console.WriteLine(carrinho.IndexOf(item));
                    global::System.Console.WriteLine($"{item.Nome} {item.Preco}");

                }
                global::System.Console.WriteLine(carrinho.count);
                carrinho.Add(livro);
                global::System.Console.WriteLine(carrinho.LastIndexOf(livro));
                
        }
    }
}
