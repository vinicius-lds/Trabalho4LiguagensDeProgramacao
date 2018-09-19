using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho4
{
    class Pessoa
    {
        private String nome { get; }
        private DateTime dataNascimento { get; }

        public Pessoa(String nome, DateTime dataNascimento)
        {
            this.dataNascimento = dataNascimento;
            this.nome = nome;
        }


        public override String ToString()
        {
            return "Nome: " + this.nome + " | Data Nascimento: " + this.dataNascimento;
        }
    }
}
