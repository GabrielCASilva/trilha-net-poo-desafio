using DesafioPOO.Models;

Iphone iphone = new (numero: "123456789", modelo: "Iphone 12", imei: "123456789", memoria: 128);
Nokia nokia = new (numero: "987654321", modelo: "Nokia 3310", imei: "987654321", memoria: 64);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");