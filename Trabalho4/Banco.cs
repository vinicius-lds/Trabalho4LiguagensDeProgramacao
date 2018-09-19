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
        public static int index = 0;

        public int addConta(String nome, DateTime dataNascimento)
        {
            ContaBase.numeroConta += 1;
            this.contas.Insert(ContaBase.numeroConta, new ContaPessoaJuridica(nome, dataNascimento));

            Console.Write("Criado conta PJ");

            return ContaBase.numeroConta;
        }

        public int addConta(String nome, DateTime dataNascimento, Mes mesConta)
        {
            ContaBase.numeroConta += 1;
            this.contas.Insert(ContaBase.numeroConta, new ContaPessoaFisica(nome, dataNascimento, mesConta));
   
            Console.Write("Criado conta PF");

            return ContaBase.numeroConta;
        }

        public String listarContas()
        {
            String lista = "Contas: \n";
            foreach(ContaBase c in this.contas){
                lista += c.ToString()+"\n";
            }
            return lista;
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
