using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia 9 Pureview:");
Smartphone nokia = new Nokia (numero: "21999886677", modelo: "Nokia 9 Pureview", imei: "222222", memoria: 128 );
nokia.Ligar();
nokia.InstalarAplicativo("Orkut");
nokia.ReceberLigacao();

Console.WriteLine("_______________________________");

Console.WriteLine("Apple iPhone 12 PRO:");
Smartphone iphone = new Iphone (numero: "22999554433", modelo: "iPhone 12", imei: "444444", memoria: 256 );
iphone.Ligar();
iphone.InstalarAplicativo("Instagram Pro");
iphone.ReceberLigacao();