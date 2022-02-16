using System;

namespace CSharp.OO
{
	/// <summary>
	/// Qualquer classe que herdar de carro vai receber os metodos asseguir 
	/// </summary>
	public class Carro {
		/// <summary>
		/// protected usado por conta da herança
		/// </summary>
		protected readonly int VelocidadeMaxima;
		int VelocidadeAtual;

		public Carro(int velocidadeMaxima) {
			VelocidadeMaxima = velocidadeMaxima;
		}

		protected int AlterarVelocidade(int delta) {
			int novaVelocidade = VelocidadeAtual + delta;

			if (novaVelocidade < 0) {
				VelocidadeAtual = 0;
			} else if (novaVelocidade > VelocidadeMaxima) {

				VelocidadeAtual = VelocidadeMaxima;
			}
			else {
				VelocidadeAtual = novaVelocidade;
			}

			return VelocidadeAtual;
		}

		/// <summary>
        /// modificador Virtual Permite ao metodo ser sobrescrito
        /// </summary>
        /// <returns></returns>
		public virtual int Acelerar() {
			return AlterarVelocidade(5);
		}

		public int Frear() {
			return AlterarVelocidade(-5);
		}
	}
	/// <summary>
	/// uno herda de carro; Construtor padrão
	/// </summary>
	class Uno : Carro {
		public Uno() : base(200) {

		}
	}

		class Ferrari : Carro
    {
		public Ferrari() : base(350) {

        }

		public override int Acelerar() {
			return AlterarVelocidade(15);
        }

		// Ocultar o método da classe Pai
		public new int Frear() {
			return AlterarVelocidade(-15);
        }
    }


	class Heranca
	{
		public static void Executar() {

            global::System.Console.WriteLine("Uno...");
			Uno carro1 = new Uno();
            global::System.Console.WriteLine(carro1.Acelerar());
            global::System.Console.WriteLine(carro1.Acelerar());
            global::System.Console.WriteLine(carro1.Frear());
            global::System.Console.WriteLine(carro1.Frear());

            global::System.Console.WriteLine("Ferrari...");
			Ferrari carro2 = new Ferrari();
			global::System.Console.WriteLine(carro2.Acelerar());
			global::System.Console.WriteLine(carro2.Acelerar());
			global::System.Console.WriteLine(carro2.Frear());
			global::System.Console.WriteLine(carro2.Frear());

            global::System.Console.WriteLine("Ferrari com tipo Carro...");
			Carro carro3 = new Ferrari();
			global::System.Console.WriteLine(carro3.Acelerar());
			global::System.Console.WriteLine(carro3.Acelerar());
			global::System.Console.WriteLine(carro3.Frear());
			global::System.Console.WriteLine(carro3.Frear());
		}
	}
}
