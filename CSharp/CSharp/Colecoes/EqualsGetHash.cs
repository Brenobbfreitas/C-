using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Console;
namespace CSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar() {

            var p1 = new Produto("Caneta", 1.99);
            var p2 = new Produto("Caneta", 1.99);
            var p3 = p2;

            // comparando por referencia de memoria 
            global::System.Console.WriteLine( p1 == p2);
            global::System.Console.WriteLine( p3 == p2);


            // comparador de endereços. podemos adicionar metodos de filtragem
            global::System.Console.WriteLine(p1.Equals(p2));


/// <summary>
/// 
/// </summary>
/// <param name="obj"></param>
/// <returns></returns> o Equal ele compara os valores e não a referencia de memoria
        //       public override bool Equals(object? obj) {
        //    Produto outroProduto = (Produto)obj;
        //    bool mesmoNome = Nome == outroProduto.Nome;
        //    bool mesmoPreco = Preco == outroProduto.Preco;
        //    return mesmoNome && mesmoPreco;
        //}
    }
    }
}
