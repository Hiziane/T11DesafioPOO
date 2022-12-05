using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula05.Models
{
    public class ContaPoupanca : Conta // herança
    {
        public double Juros { get; set; }
        
        public override void ExibirTipoConta()
        {
            Console.WriteLine("Conta Poupança");
        }

        public override void ExibirResumoConta()
        {
            base.ExibirResumoConta();
            Console.WriteLine($"Juros : {Juros}");
        }
                
    }
}