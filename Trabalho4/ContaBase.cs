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
        protected float saldo { get; set; }
        public static int numeroConta { get; set;}

        public ContaBase(String nome, DateTime dataNascimento)
        {
            this.pessoa = new Pessoa(nome, dataNascimento);
        }

        public override String ToString()
        {
            return this.pessoa.ToString() + " | Conta: " + numeroConta + " | Saldo: " + this.saldo;
        }
    }
}
