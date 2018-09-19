using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho4
{
    class ContaBase
    {
        private Pessoa pessoa { get; }
        public float saldo { get; set; }
        public static int numeroConta = 0;
        public int index { get; set; }

        public ContaBase(String nome, DateTime dataNascimento)
        {
            this.pessoa = new Pessoa(nome, dataNascimento);
            this.index = numeroConta;
        }

        public override String ToString()
        {
            return "Conta: " + this.index + this.pessoa.ToString() + " | Saldo: " + this.saldo;
        }
    }
}
