﻿var contador = 10;

do{
    Console.WriteLine(contador);
    contador++;
}while(contador < 10);

//======================================================================
var opcao = "";

do{
    Console.WriteLine("Digite uma opção:");
    Console.WriteLine("1 - Saque | 2 - Depósito | 3 - Saldo | 0 - Sair");
    opcao = Console.ReadLine();

    switch(opcao){
        case "1":
            Console.WriteLine("Saque realizado.");
            break;
        case "2":
            Console.WriteLine("Depósito realizado.");
            break;
        case "3":
            Console.WriteLine("Saldo disponível: R$ 100,00");
            break;    
    }
}while(opcao != "0");

//======================================================================

int soma = 0, numero = 0;

do{
    Console.WriteLine("Digite um numero (0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;
}while(numero != 0);
Console.WriteLine($"Total da soma dos números digitados é: {soma}");