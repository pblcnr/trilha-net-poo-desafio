using DesafioPOO.Models;

Console.WriteLine("Smartphone NOKIA");
Smartphone nokia = new Nokia("1234", "Deluxe", "11111", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("\n----------------------------");

Console.WriteLine("Smartphone IPHONE");
Smartphone iphone = new Iphone("9876", "16 Pro Max", "22222", 246);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Twitter");
iphone.InstalarAplicativo("Brawl Stars");