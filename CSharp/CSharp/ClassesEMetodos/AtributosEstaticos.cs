

namespace CSharp.ClassesEMetodos
{

    public class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1; //após definir como valor estatico ele deixa de pertencer a instancia e vira da classe

        public Produto(string nome, double preco, double desconto) {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto() {

        }

        public double CalcularDesconto() { //metodo
            return Preco - Preco * Desconto;
        }
    }
    internal class AtributosEstaticos
    {
        public static void Executar() {
            var produto1 = new Produto("Caneta", 3.2, 0.1);

            var produto2 = new Produto() {
                Nome = "Borrachar",
                Preco = 5.0,
            };


            Produto.Desconto = 0.5;

            Console.WriteLine("preço com desconto: {0}", 
                produto1.CalcularDesconto());

            Console.WriteLine("preço com desconto: {0}", 
                produto2.CalcularDesconto());

            Produto.Desconto = 0.02;

            Console.WriteLine("preço com desconto: {0}",
               produto1.CalcularDesconto());

            Console.WriteLine("preço com desconto: {0}",
                produto2.CalcularDesconto());


        }
    }
}
