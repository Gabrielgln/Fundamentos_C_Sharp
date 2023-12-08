List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

for(int i = 0; i < listaString.Count; i++){
    Console.WriteLine(listaString[i]);
}

listaString.Remove("MG");

foreach (var item in listaString){
   Console.WriteLine(item); 
}