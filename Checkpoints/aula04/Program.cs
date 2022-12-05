using aula05.Models;

ContaCorrente c1 = new ContaCorrente();
Console.WriteLine("\nConta Corrente :");
c1.Nome = "Hiza";
c1.Agencia = 123;
c1.Numero = 9999;
c1.Depositar(500);
c1.ExibirSaldo();
c1.Tarifa = 2;
c1.Senha = "ABC";
c1.ExibirResumoConta();


ContaPoupanca c2 = new ContaPoupanca();
Console.WriteLine("\nConta Poupança :");
c2.Nome = "Mari";
c2.Agencia = 456;
c2.Numero = 3333;
c2.Juros = 15;
c2.Depositar(50);
c2.ExibirSaldo();
c2.ExibirResumoConta();