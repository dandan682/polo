using Billetera;

Billetera b1 = new Billetera(1, 1, 1, 1, 1, 1, 1);
Billetera b2 = new Billetera(1, 1, 1, 1, 1, 1, 1);
Billetera b3 = b1.Combinar(b2);

Console.WriteLine(b1.Total());
Console.WriteLine(b2.Total());
Console.WriteLine(b3.Total());

