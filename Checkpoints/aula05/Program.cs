using aula05.Models;

ContaCorrente c1 = new ContaCorrente();
//Console.WriteLine("\nConta Corrente :");
Console.WriteLine("\n");
c1.ExibirTipoConta(); // polimorfismo
c1.Nome = "Hiza";
c1.Agencia = 123;
c1.Numero = 9999;
c1.Tarifa = 15;
c1.Senha = "ABC";
c1.Depositar(100);
c1.ExibirSaldo();
c1.ExibirResumoConta();

Console.WriteLine("\n");

ContaPoupanca c2 = new ContaPoupanca();
c2.ExibirTipoConta();
c2.Nome = "Elly";
c2.Numero = 5555;
c2.Agencia = 456;
c2.Juros = 15;
c2.Depositar(200);
c2.ExibirResumoConta();
