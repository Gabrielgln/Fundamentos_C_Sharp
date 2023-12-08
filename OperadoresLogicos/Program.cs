var ativo = true;
Console.WriteLine(ativo);
var a = 3;
var b = 6;

//      OPERADOR NOT (NÃO)

bool choveu = true;
bool estaTarde = false;

if(!choveu && !estaTarde){
    Console.WriteLine("Vou pedalar");
}else{
    Console.WriteLine("Vou pedalar um outro dia");
}

Console.WriteLine(!ativo);
Console.WriteLine(!(a > b)); //a não é maior que b



//      OPERADOR AND (E)
//--------------------------|
//OP1   | OP2   | RESULTADO |
//--------------------------|
//True  | True  | True      |
//True  | False | False     |
//False | True  | False     |
//False | False | False     |
//--------------------------|

Console.WriteLine(ativo == true && a > b);

bool possuiPresencaMininma = false;
double media = 7.5;

if(possuiPresencaMininma && media >= 7){
    Console.WriteLine("Aprovado");
}else{
    Console.WriteLine("Reprovado");
}

//      OPERADOR OR (OU)
//--------------------------|
//OP1   | OP2   | RESULTADO |
//--------------------------|
//True  | True  | True      |
//True  | False | True      |
//False | True  | True      |
//False | False | False     |
//--------------------------|

Console.WriteLine(ativo == true || a < b);

bool ehMaiorDeIdade = true;
bool possuiAutorizacaoDoResponsavel = false;

if(ehMaiorDeIdade || possuiAutorizacaoDoResponsavel){
    Console.WriteLine("Entrada liberada");
}else{
    Console.WriteLine("Entrada não liberada");
}





