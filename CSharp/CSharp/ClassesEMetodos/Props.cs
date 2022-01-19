using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ClassesEMetodos
{

    public class CarroOpcional
    {
        double desconto = 0.1; // quando não declarado como public, por padrão privado
        
        string nome;

        public string Nome {
            get {
                return "Opcional: " + nome;
            }
            set {
                nome = value; // valor passado é associado a value
            }
        }

        //Propriedade autoimplementada
        public double Preco { get; set; }

        //Propriedade Somente Leitura
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco); //Lambda
            //get {
            //    return Preco - (desconto * Preco);
            //}
        }

        public CarroOpcional() {//construtor

        }

        public CarroOpcional(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }
    internal class Props
    {
        public static void Executar() {
            var op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(op1.Preco);
            Console.WriteLine(op1.PrecoComDesconto); // propriedade PrecoComDesconto é apenas de leitura; não conseguimos alterar

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349.9;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);
            

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);
        }
    }
}
