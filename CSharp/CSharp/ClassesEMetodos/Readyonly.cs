using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ClassesEMetodos
{

    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento;
            //com o readonly conseguimos inicializar a variavel no Construtor
        public Cliente(string nome, DateTime nascimento) { //Construtor
            Nome = nome;
            Nascimento = nascimento;
            Nascimento = new DateTime(2020, 10, 10); 

            //Readonly setar um valor imutavel sem ser inicializado diretamento na declaração
        }

        public string GetDataDeNascimento() {
            return String.Format("{0}/{1}/{2}", Nascimento.Day,
                Nascimento.Month, Nascimento.Year);

        }
    }
    internal class Readyonly
    {
        public static void Executar() {
            var novoCliente = new Cliente("Ana Silva", new DateTime(1998, 6, 17));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());

        }
    }
}
