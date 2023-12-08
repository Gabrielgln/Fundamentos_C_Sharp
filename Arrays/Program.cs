int[] numeros = new int[3];
numeros[0] = 10;
numeros[1] = 20;
numeros[2] = 30;

Console.WriteLine(numeros[0]);
Console.WriteLine(numeros[1]);
Console.WriteLine(numeros[2]);

int[] pares = new int[3] {2, 4, 6};
Console.WriteLine(pares[0]);
Console.WriteLine(pares[1]);
Console.WriteLine(pares[2]);

int[] impares = new int[] {3, 5, 7, 9};
Console.WriteLine(impares[0]);
Console.WriteLine(impares[1]);
Console.WriteLine(impares[2]);
Console.WriteLine(impares[3]);

string[] nomes = new [] {"Gabriel", "Verônica", "João"};
Console.WriteLine(nomes[0]);
Console.WriteLine(nomes[1]);
Console.WriteLine(nomes[2]);

string[] paises = {"Brasil", "EUA", "França"};
Console.WriteLine(paises[0]);
Console.WriteLine(paises[1]);
Console.WriteLine(paises[2]);

var cidades = new [] {"Patos", "Sousa", "João Pessoa", "Pombal"};

Console.WriteLine("Percorrendo usando o For");
for(int i = 0; i < cidades.Length; i++){
    Console.WriteLine(cidades[i]);
}

Console.WriteLine("Percorrendo usando o Foreach");
foreach(var cidade in cidades){
    Console.WriteLine(cidade);
}


//Copiando de um array para outro
int[] arrayInteiros = {1, 3, 5, 7};
int[] arrayInteirosCopia = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosCopia, arrayInteiros.Length);
