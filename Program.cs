using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456789", "Nokia 3310", "IMEI123456", 16);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone("987654321", "iPhone 13", "IMEI987654", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");