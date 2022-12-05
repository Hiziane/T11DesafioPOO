using Checkpoints.Models;

ContaCorrente contaC = new ContaCorrente();
Console.WriteLine("\nConta Corrente :");
contaC.Nome = "Hiza";
contaC.Agencia = 123;
contaC.Numero = 9999;
contaC.Saldo = 500;
contaC.Tarifa = 15;
contaC.Depositar(100);
contaC.ExibirResumoConta();

ContaPoupanca contaP = new ContaPoupanca();
Console.WriteLine("\nConta Poupança :");
contaP.Nome = "Manu";
contaP.Agencia = 456;
contaP.Numero = 5555;
contaP.Saldo = 500;
contaP.Juros = 2;
contaP.Depositar(100);
contaP.ExibirResumoConta();