var hoje = DateTime.Today;
var agora = DateTime.Now;
Console.WriteLine(hoje);
Console.WriteLine(agora);

var data1 = new DateTime(2020, 03, 11);
var data2 = new DateTime(2023, 11, 30, 11, 20, 11);
var data3 = DateTime.Parse("15/11/2023 12:43:50");
Console.WriteLine(data1);
Console.WriteLine(data2);
Console.WriteLine(data3);

Console.WriteLine(data3.Day);
Console.WriteLine(data3.Month);
Console.WriteLine(data3.Year);
Console.WriteLine(data3.Hour);
Console.WriteLine(data3.Second);

Console.WriteLine(data3.AddDays(5));
Console.WriteLine(data3.AddMonths(-1));

Console.WriteLine(data3.ToLongDateString());
Console.WriteLine(data3.ToLongTimeString());
Console.WriteLine(data3.ToShortDateString());
Console.WriteLine(data3.ToShortTimeString());

