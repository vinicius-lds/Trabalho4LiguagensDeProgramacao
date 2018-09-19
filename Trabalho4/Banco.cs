using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho4
{
    class Banco
    {
        private List<ContaBase> contas = new List<ContaBase>();

        public int addConta(String nome, DateTime dataNascimento)
        {
            ContaBase.numeroConta += 1;
            this.contas.Add(new ContaPessoaJuridica(nome, dataNascimento));

            Console.Write("Criado conta PJ\n");

            return ContaBase.numeroConta;
        }

        public int addConta(String nome, DateTime dataNascimento, Mes mesConta)
        {
            ContaBase.numeroConta += 1;
            this.contas.Add(new ContaPessoaFisica(nome, dataNascimento, mesConta));
   
            Console.Write("Criado conta PF\n");

            return ContaBase.numeroConta;
        }

        public String listarContas()
        {
            String lista = "Contas Bancarias \n";
            foreach(ContaBase c in this.contas){
                lista += c.ToString() + "\n";
            }
            return lista;
        }

        public bool saque(int numeroConta, float valorSaque, out float taxa)
        {
            return this.buscarConta(numeroConta).sacar(valorSaque, out taxa);
        }

        public bool deposito(int numeroConta, float valor)
        {
            return this.buscarConta(numeroConta).depositar(valor);
        }

        public float totalConta(int numeroConta)
        {
            foreach(ContaBase c in this.contas)
            {
                if (c.index == numeroConta)
                {
                    return c.saldo;
                }
            }

            return 0f;
        }

        public float emprestimo(int numeroConta, float valor)
        {
            return this.buscarConta(numeroConta).empresta(valor);
        }

        private Transacao buscarConta(int numeroConta)
        {
            foreach(ContaBase c in this.contas)
            {
                if (c.index == numeroConta)
                {
                    Transacao t;
                    try
                    {
                        t = (ContaPessoaFisica) c;
                    }
                    catch (Exception e)
                    {
                        t = (ContaPessoaJuridica) c;
                    }

                    return t;
                }
            }

            return null;
        }
    }
}
