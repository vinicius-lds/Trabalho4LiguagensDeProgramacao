using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho4
{
    interface Transacao
    {
        bool sacar(float valorDoSaque, out float taxaDoSaque);
        bool depositar(float valorDoDeposito);
        float empresta(float valorEmprestimo);
    }
}
