using System.Globalization;
//Mudar a localização do codígo:
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

decimal valorMonetario = 1540.30m;

Console.WriteLine($"{valorMonetario:C}");
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
Console.WriteLine(valorMonetario.ToString("C1"));
Console.WriteLine(valorMonetario.ToString("C2"));
Console.WriteLine(valorMonetario.ToString("N2"));


double porcetagem = .3656;
Console.WriteLine(porcetagem.ToString("P"));

int numero = 330022;
Console.WriteLine(numero.ToString("##-##-##"));


DateTime data1 = DateTime.Now;
Console.WriteLine(data1.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data1.ToString("yyyy-MM-dd HH:mm"));

//DateTime data2 = DateTime.Parse(dateString);
//Console.WriteLine(data2);

string dateString = "2022-12-17 18:00";
bool success = DateTime.TryParse(dateString, out DateTime dateTime);
if(success){
    Console.WriteLine(dateTime);
}else{
    Console.WriteLine("Formato inválido");
}
