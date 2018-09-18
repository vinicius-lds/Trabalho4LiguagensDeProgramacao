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
            throw new NotImplementedException();
        }

        public float empresta(float valorEmprestimo)
        {
            throw new NotImplementedException();
        }

        public bool sacar(float valorDoSaque, out float taxaDoSaque)
        {
            throw new NotImplementedException();
        }
    }
}
