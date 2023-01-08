//using bytebank;

//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "André silva";
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.conta = "1010-x";
//contaDoAndre.saldo = 100;

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Souza";
//contaDaMaria.numero_agencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;

//Console.WriteLine("Saldo da conta d Maria = " + contaDaMaria.saldo);

//contaDoAndre.Transferir(50, contaDaMaria);
//Console.WriteLine("Saldo da conta do andré = " + contaDoAndre.saldo);
//Console.WriteLine("Saldo da conta da Maria = " + contaDaMaria.saldo);

//ContaCorrente contaDoPedro= new ContaCorrente();
//Console.WriteLine(contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.saldo);
//Console.WriteLine(contaDoPedro.numero_agencia);
//Console.WriteLine(contaDoPedro.conta);

//using bytebank;

//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "André Silva";
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.conta = "1010-X";
//contaDoAndre.saldo = 100;
//Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);

//ContaCorrente contaDoAndre2 = new ContaCorrente();
//contaDoAndre2.titular = "André Silva";
//contaDoAndre2.numero_agencia = 15;
//contaDoAndre2.conta = "1010-X";
//contaDoAndre2.saldo = 100;
//Console.WriteLine("Saldo da conta do André = " + contaDoAndre2.saldo);

//Console.WriteLine(contaDoAndre == contaDoAndre2);

//using bytebank.Contas;
//using bytebank.Titular;

//Cliente cliente = new Cliente();
//cliente.nome = "André silva";
//cliente.Cpf = "123456789";
//cliente.Profissão = "Analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numero_agencia = 15;
//conta.saldo = 100;

//Console.WriteLine("titular= " + conta.titular.nome);
//Console.WriteLine("cpf= " + conta.titular.Cpf);
//Console.WriteLine("profissão= " + conta.titular.Profissão);
//Console.WriteLine("n conta= " + conta.conta);
//Console.WriteLine("Saldo= " + conta.saldo);
//Console.WriteLine("n agencia= " + conta.numero_agencia);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "jose souza";
//conta2.titular.Profissão = "Tester";
//conta2.titular.Cpf = "15236585892";
//conta2.conta = "999-X";
//conta2.numero_agencia = 15;
//conta2.saldo = 500;
//Console.WriteLine(conta2.titular.nome);

//using bytebank.Contas;

//ContaCorrente conta3 = new ContaCorrente();
//conta3.Numero_agencia= 18;
//conta3.Conta = "1011-H";
//conta3.SetSaldo(200);
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.Numero_agencia);
//Console.WriteLine(conta3.Conta);



using bytebank.Contas;
using bytebank.Titular;

//ContaCorrente conta4 = new ContaCorrente(18,"1010-X");
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();

//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_agencia);

ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta6 = new ContaCorrente(284, "9874-Z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


