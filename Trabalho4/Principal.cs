using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho4
{
    class Principal
    {
        static void Main(string[] args)
        {
            Banco b = new Banco();
            System.Console.WriteLine("Conta: " + b.addConta("Carlos", DateTime.Now));
            System.Console.WriteLine("Conta: " + b.addConta("Maria", DateTime.Now, Mes.MAIO));
            System.Console.WriteLine("Conta: " + b.addConta("Vinicius", DateTime.Now));
            System.Console.WriteLine("Conta: " + b.addConta("Ze", DateTime.Now, Mes.DEZEMBRO));


            b.deposito(1, 500f);
            b.deposito(2, 200f);
            b.deposito(3, 300f);
            b.deposito(4, 400f);
            b.deposito(1, 500f);
        }
    }
}
