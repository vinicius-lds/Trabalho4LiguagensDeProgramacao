using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho4
{
    class ContaPessoaJuridica : ContaBase, Transacao
    {

        public ContaPessoaJuridica(string nome, DateTime dataDeNascimento) : base(nome, dataDeNascimento)
        {
            
        }

        public bool depositar(float valorDoDeposito)
        {
            base.saldo += valorDoDeposito;
            return true;
        }

        public float empresta(float valorEmprestimo)
        {
            return valorEmprestimo + (valorEmprestimo * 0.1f);
        }

        public bool sacar(float valorDoSaque, out float taxaDoSaque)
        {
            taxaDoSaque = 0;
            if (valorDoSaque < base.saldo)
            {
                return false;
            }
            else
            {
                taxaDoSaque = valorDoSaque * 0.05f;
                base.saldo -= valorDoSaque + taxaDoSaque;
                return true;
            }
        }
    }
}
