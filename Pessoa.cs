using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Pessoa
    {
        public string nome;
        public int idade;

        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é: {nome}");
        }
    }
}
