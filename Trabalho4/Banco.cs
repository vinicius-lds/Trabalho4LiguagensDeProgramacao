using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho4
{
    class Banco
    {
        private List<ContaBase> contas { get; }

        public int addConta(String nome, DateTime dataNascimento)
        {
            return 1;
        }

        public int addConta(String nome, DateTime dataNascimento, Mes mesConta)
        {
            return 1;
        }

        public String listarContas()
        {
            return null;
        }

        public bool saque(int numeroConta, float valorSaque, out float taxa)
        {
            taxa = 0;
            return true;
        }

        public bool deposito(int numeroConta, float valor)
        {
            return true;
        }

        public float totalConta(int numeroConta)
        {
            return 5f;
        }

        public float emprestimo(int numeroConta, float valor)
        {
            return 5f;
        }
    }
}
