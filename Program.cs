using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone iphone = new Iphone(numero: "71 12345678", modelo: "Iphone 15", imei: "21323123", memoria: 256);
Console.WriteLine("Iphone");
iphone.ExibirNumero();
iphone.ExibirModelo();
iphone.ExibirIMEI();
iphone.ExibirMemoriaDocelular();
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Smartphone nokia = new Nokia(numero: "71 87654321", modelo: "C21 Plus", imei: "14521478", memoria: 128);
Console.WriteLine("Nokia");
nokia.ExibirNumero();
nokia.ExibirModelo();
nokia.ExibirIMEI();
nokia.ExibirMemoriaDocelular();
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");