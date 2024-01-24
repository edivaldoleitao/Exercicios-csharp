using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoExemplo.Common.Models
{
    //classe abstract que não pode ser instanciada, somente pode ser herdada
    public abstract class Conta
    {
        //pode ser acessado pelas classes filhas
        protected decimal saldo;

        public abstract void Creditar(decimal saldo);
        public void ExibirSaldo()
        {
            Console.WriteLine("saldo"+saldo);
        }
    }
}