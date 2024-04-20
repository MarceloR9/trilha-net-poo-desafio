using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e 

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "08004545", modelo: "Nokia 1", imei: "000000000", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "08009595", modelo: "Iphone 1", imei: "111111111", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("TikTok");