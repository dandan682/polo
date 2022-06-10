// Ejercicio Clase 13 - Billetera

using Billeteras;

Billetera b1 = new Billetera(5, 3, 5, 2, 3, 2, 1);
Billetera b2 = new Billetera(6, 7, 4, 8, 9, 6, 2);


Console.WriteLine($"Total Billetera #1: ${b1.Total():#,#0}");
Console.WriteLine($"Total Billetera #2: ${b2.Total():#,#0}");

Console.WriteLine("\nCombinando billeteras 1 y 2...");
Billetera b3 = b1.Combinar(b2);

Console.WriteLine("\nBilleteras despues de combinar:");

Console.WriteLine($"Total Billetera #3: ${b3.Total():#,#0}");
Console.WriteLine($"Total Billetera #2: ${b2.Total():#,#0}");
Console.WriteLine($"Total Billetera #1: ${b1.Total():#,#0}");