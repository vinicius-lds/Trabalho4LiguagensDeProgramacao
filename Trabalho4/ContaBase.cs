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
        private float saldo { get; }
        private int numeroConta { get; }

        public ContaBase(String nome, DateTime dataNascimento)
        {

        }

        public override String ToString()
        {
            return null;
        }
    }
}
