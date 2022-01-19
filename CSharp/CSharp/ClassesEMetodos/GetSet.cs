using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ClassesEMetodos
{

    public class Moto
    {
        private string Marca;
        private string Modelo; //Quando o valor é privado vc precisa de um metodo para acessalo
        private uint Cilindrada; //sempre um valor positivo/ SETA o valor do atributo quando quer alter/ ou ler o valor GET
        //uint valor obrigatoriamente positivo
        public Moto(string marca, string modelo, uint cilindrada) { // Construtor
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);

        }

        public Moto() { //construtor
        
        }

        public string GetMarca() { // operação de leitura
            return Marca;
        }

        public void SetMarca(string marca) { // alterar a marca
            Marca = marca;
        }

        public string GetModelo() {
            return Modelo;
        }

        public void SetModelo(string modelo) {
            Modelo = modelo;
        }

        public uint GetCilindrada() {
            return Cilindrada;
        }
    
        public void SetCilindrada(uint cilindrada) {
            // 1 Opção
            //if(cilindrada > 0) {
            //Cilindrada = cilindrada;
            //}
            // 2 Opção
            /*Cilindrada = Math.Abs(cilindrada);*/ //transforma valores negativos em positivos
            Cilindrada = cilindrada;
        }
    }
    internal class GetSet
    {
        public static void Executar() {
            var moto1 = new Moto("kawasaki", "Ninja ZX-GR", 636);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetModelo("CG Titan");
            moto2.SetMarca("Honda");
            moto2.SetCilindrada(150);

            Console.WriteLine(moto2.GetMarca()+" "+moto2.GetModelo()+" "+moto2.GetCilindrada());
        }
    }
}
