using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoExemplo.Models
{   
    // nenhuma classe pode herdar dessa classe
    public sealed class  ContaCorrente : Conta
    {
        // nenhuma método pode sobrescrever esse método
        public sealed override void Creditar(decimal credito)
        {
            //alterando o campo protected
            saldo += credito;
        }
    }
}