﻿using bytebank;

ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-x";
contaDoAndre.saldo = 100;

ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = "Maria Souza";
contaDaMaria.numero_agencia = 17;
contaDaMaria.conta = "1010-5";
contaDaMaria.saldo = 350;

Console.WriteLine("Saldo da conta d Maria = " + contaDaMaria.saldo);

contaDoAndre.Transferir(50, contaDaMaria);
Console.WriteLine("Saldo da conta do andré = " + contaDoAndre.saldo);
Console.WriteLine("Saldo da conta da Maria = " + contaDaMaria.saldo);



/*
Console.WriteLine("Saldo da conta do andré = " + contaDoAndre.saldo);

contaDoAndre.Depositar(100);

Console.WriteLine("Saldo da conta do andré pós deposito = " + contaDoAndre.saldo);

if (contaDoAndre.Sacar(100) == true)
{
    Console.WriteLine("Saldo da conta do andré pós saque = " + contaDoAndre.saldo);
}
else
{
    Console.WriteLine("Saldo insuficiente");
}*/

