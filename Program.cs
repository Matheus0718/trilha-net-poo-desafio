using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "1298908-8737", modelo: "N95", imei: "1111-222-333", memoria: 120);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");


Console.WriteLine("--------------------------------");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "1298829-82892", modelo: "13 Pro MAX", imei: "1111111-2222222", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Ifood");



// TODO: Realizar os testes com as classes Nokia e Iphone