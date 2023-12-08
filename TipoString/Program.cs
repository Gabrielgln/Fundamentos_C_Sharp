var nome = "Gabriel";
var sobrenome = "Lira";

var nomeCompleto = nome + " " + sobrenome;
var nomeCompletoInterpolado = $"{nome} {sobrenome}.";
Console.WriteLine(nomeCompleto);
Console.WriteLine(nomeCompletoInterpolado);
//Caixa alta, caixa menor:
Console.WriteLine(nomeCompleto.ToUpper());
Console.WriteLine(nomeCompleto.ToLower());
//Pegar uma parte da string:
Console.WriteLine(nomeCompleto.Substring(8));
Console.WriteLine(nomeCompleto.Substring(8, 4));
//Se contém na string:
Console.WriteLine(nomeCompleto.Contains('o'));
Console.WriteLine(nomeCompleto.Contains("Li"));
//Se começa com ou se termina com:
Console.WriteLine(nomeCompleto.StartsWith("G"));
Console.WriteLine(nomeCompleto.EndsWith("e"));
//Primeira posição de um determinado caractere:
Console.WriteLine(nomeCompleto.IndexOf("i"));
//Ultima posição de um determinado caractere:
Console.WriteLine(nomeCompleto.LastIndexOf("i"));

