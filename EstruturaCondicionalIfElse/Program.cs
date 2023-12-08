var idade = 16;
var nota = 7;

if(idade >= 18){
    Console.WriteLine("Maior de idade");
    Console.WriteLine("Cadastro autorizado");
}
else if(idade >= 16){
    Console.WriteLine("Menor de idade, maior que 16 anos");
    Console.WriteLine("Cadastro autorizado com responsáveis");
}else{
    Console.WriteLine("Menor de idade");
    Console.WriteLine("Cadastro não autorizado");
}

bool aprovado = nota >= 7;

if(aprovado){
    Console.WriteLine("Aprovado");
}else{
    Console.WriteLine("Reprovado");
}



Console.WriteLine("Finalizado");
