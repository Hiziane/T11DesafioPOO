using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula05.Models
{
    public class ContaCorrente : Conta
    {
        
        
        public double Tarifa { get; set; }

        public override void ExibirTipoConta()
        {
            Console.WriteLine("Conta Corrente");
        }

    }
}