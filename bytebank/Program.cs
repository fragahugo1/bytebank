using bytebank.Contas;
using bytebank.Titular;

Cliente cliente = new Cliente();
cliente.Nome = "Hugo Fraga";
cliente.CPF = "1252595";
cliente.Profissao = "Programador";

ContaCorrente contaHugo = new ContaCorrente(17, "17x11");
contaHugo.Titular = cliente;

//contaHugo.Depositar(500);
//Console.WriteLine("Saldo de Hugo pós deposito: " + contaHugo.saldo);

//if (contaHugo.Sacar(200) == true)
//    Console.WriteLine("Saldo de Hugo pós saque: " + contaHugo.saldo);
//else
//    Console.WriteLine("Saldo insuficiente para saque");

ContaCorrente contaLais = new ContaCorrente(20, "01p2");

//contaHugo.Transferir(900, contaLais);
//Console.WriteLine("Saldo de Hugo " + contaHugo.saldo);
//Console.WriteLine("Saldo de Lais " + contaLais.saldo);

contaHugo.SetSaldo(1320.8);
//Console.WriteLine(contaHugo.GetSaldo());

contaHugo.MinhaConta();
Console.WriteLine("Total de contas no banco: " + ContaCorrente.TotalContas);