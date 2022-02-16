using System;

namespace CSharp.OO
{
    public class Animal
    {
        public string Name { get; set; }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="nome"></param>
        public Animal(string nome) {
            Name = nome;
        }
    }


    public class Cachorro : Animal
    {
        public double Altura{ get; set; }

        public Cachorro(string nome) : base(nome) {
            global::System.Console.WriteLine($"Cachorro {nome} inicializado");
        }

        public Cachorro(string nome, double altura) : this(nome) { 
                Altura = altura;
        }

        public override string ToString() {
            return $"{Name} tem {Altura}cm de altura!";
        }
    }

    class ConstrutoThis
    {
        public static void Executar() {
            var spike = new Cachorro("Spike");
            var max = new Cachorro("Max", 40.0); 
        }
    }
}