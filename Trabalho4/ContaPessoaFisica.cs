using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho4
{
    class ContaPessoaFisica : ContaBase, Transacao
    {
        Mes mesConta;

        public ContaPessoaFisica(String nome, DateTime dataNascimento, Mes mesConta) : base (nome, dataNascimento)
        {
            this.mesConta = mesConta;
        }

        public bool depositar(float valorDoDeposito)
        {
            base.saldo += valorDoDeposito;
            return true;
        }

        public float empresta(float valorEmprestimo)
        {
            int mesAtual = DateTime.Now.Month;
            int mesConta;
            switch(this.mesConta)
            {
                case Mes.JANEIRO:
                    mesConta = 1;
                    break;
                case Mes.FEVEREIRO:
                    mesConta = 2;
                    break;
                case Mes.MARÇO:
                    mesConta = 3;
                    break;
                case Mes.ABRIL:
                    mesConta = 4;
                    break;
                case Mes.MAIO:
                    mesConta = 5;
                    break;
                case Mes.JUNHO:
                    mesConta = 6;
                    break;
                case Mes.JULHO:
                    mesConta = 7;
                    break;
                case Mes.AGOSTO:
                    mesConta = 8;
                    break;
                case Mes.SETEMBRO:
                    mesConta = 9;
                    break;
                case Mes.OUTUBRO:
                    mesConta = 10;
                    break;
                case Mes.NOVEMBRO:
                    mesConta = 11;
                    break;
                case Mes.DEZEMBRO:
                    mesConta = 12;
                    break;
                default:
                    throw new Exception("Mês inválido!");
            }
            float modDiferenca = mesAtual - mesConta;
            if (modDiferenca < 0)
            {
                modDiferenca = modDiferenca * (-1);
            }
            return valorEmprestimo + ((valorEmprestimo * (modDiferenca / 100)) * 5);
        }

        public bool sacar(float valorDoSaque, out float taxaDoSaque)
        {
            taxaDoSaque = 0;
            if(valorDoSaque < base.saldo)
            {
                return false;
            }
            else
            {
                taxaDoSaque = valorDoSaque * 0.01f;
                base.saldo -= valorDoSaque + taxaDoSaque;
                return true;
            }
        }
    }
}
