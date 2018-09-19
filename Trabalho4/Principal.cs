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
            ContaPessoaJuridica pj = new ContaPessoaJuridica("vinicius", DateTime.Now);
            System.Console.WriteLine(pj.empresta(100));
        }
    }
}
