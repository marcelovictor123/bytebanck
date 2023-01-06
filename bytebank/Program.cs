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

using bytebank;

ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 100;
Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);

ContaCorrente contaDoAndre2 = new ContaCorrente();
contaDoAndre2.titular = "André Silva";
contaDoAndre2.numero_agencia = 15;
contaDoAndre2.conta = "1010-X";
contaDoAndre2.saldo = 100;
Console.WriteLine("Saldo da conta do André = " + contaDoAndre2.saldo);

Console.WriteLine(contaDoAndre == contaDoAndre2);


