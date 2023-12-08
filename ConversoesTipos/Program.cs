//Conversões implícitas:

int anoInt = 2020;
//float ano2 = ano;
//decimal ano2 = ano;
double anoDouble = anoInt;
Console.WriteLine(anoDouble);

// decimal taxaDecimal = 12.98m;
// int taxaInt = taxaDecimal;


//Conversões explícitas (Perca de dados!):
decimal taxaDecimal = 12.98m;
int taxaInt = (int)taxaDecimal;
Console.WriteLine(taxaInt);


//Classes e métodos para conversões:
string taxaString = taxaDecimal.ToString();
Console.WriteLine(taxaString);

string resposta = "12";
int idade = int.Parse(resposta);
int idade2 = Convert.ToInt32(resposta);
Console.WriteLine(idade);
Console.WriteLine(idade2);

