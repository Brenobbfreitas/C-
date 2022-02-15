using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Colecoes
{
        class ColecoesSet
        {
            public static void Executar() {
                var livro = new Produto("Gatilho", 78.99);


                var carrinho = new HashSet<Produto>();
                carrinho.Add(livro);
                /// O list é uma estrutura indexada
                var combo = new HashSet<Produto>() {
                    new Produto("Camisa", 29.90),
                    new Produto("8 Temporada Aflex", 65.69),
                    new Produto("Shots", 52.55)
                }
                    ///metodo para adicionar conteudo de uma lista dentro de outro
                carrinho.UnionWith(combo);
                console.WriteLine(carrinho.Count);//verifica tamanho da linha
                //carrinho.RemoveAt(3); //remover o elemento de indice 3 


                foreach (var item in carrinho) {
                    //global::System.Console.WriteLine(carrinho.IndexOf(item));
                    Console.WriteLine($"{item.Nome} {item.Preco}");

                }
                Console.WriteLine(carrinho.count);
                carrinho.Add(livro);
               // global::System.Console.WriteLine(carrinho.LastIndexOf(livro));

            }
        }
    }
