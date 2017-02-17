using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    //SOLID - OCP com Extension Methods

    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public string FormatarNome()
        {
            return Nome + "" + Sobrenome;
        }

    }

    public static class ExtensionPessoa
    {

        public static int NomeLength(this Pessoa pessoa)
        {

            return pessoa.FormatarNome().Length;

        }

    }


    class Exemplo
    {
        static void Main(string[] args)
        {

            var pessoa = new Pessoa
            {
                Nome = "Eli",
                Sobrenome = "Pedro"
            };

            Console.WriteLine("Length: {0} ", pessoa.NomeLength());
            Console.ReadKey();
        }
    }
}
