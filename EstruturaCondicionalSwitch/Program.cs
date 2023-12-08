Console.WriteLine("Digite um opção:");
var opcao = Console.ReadLine();

switch(opcao){
    case "1":
        Console.WriteLine("Seu saldo é R$ 100,00");
        break;
    case "2":
        Console.WriteLine("Informe o valor do depósito");
        break;
    case "3":
        Console.WriteLine("Informe o valor do saque");
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}

Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch(letra.ToLower()){
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("É uma vogal");
        break;
    default:
        Console.WriteLine("Não é uma vogal");
        break;
}
