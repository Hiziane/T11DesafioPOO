using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkpoints.Models
{
    public class ContaPoupanca
    {
        public string? Nome { get; set; } // string precisa do ? para não dar erro
        public int Numero { get; set; }
        public int Agencia { get; set; }
        public double Juros { get; set; }
        public double Saldo { get; set; }

        public void Depositar (double valor)
        {
            Saldo = Saldo + valor;
        }

        public void ExibirResumoConta()
        {
            Console.WriteLine($"Correntista : {Nome}");
            Console.WriteLine($"Numero :       {Numero}");
            Console.WriteLine($"Agencia :      {Agencia}");
            Console.WriteLine($"Saldo :        {Saldo}");
        }
        
    }
}