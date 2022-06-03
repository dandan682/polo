
int[,] carton = new int[9,3];
Random aleatorio = new Random();

for (int i = 0; i < carton.GetLength(1); i++)
{
    for (int j = 0; j < carton.GetLength(0); j++)
    {
        carton[j, i] = aleatorio.Next(10 * j,10 * j + 9);
//        Console.ReadKey();
    }
}

// Mostramos el carton
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine($"\t\t\t\t\t\t\tCarton #{0 + 1}");
for (int i = 0; i < carton.GetLength(1); i++)
{
    Console.Write("\n\t\t\t\t");
    for (int j = 0; j < carton.GetLength(0); j++)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("|");
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write($" {(carton[j,i] < 10 ? (carton[j, i] == 0 ? "&&" : $"0{carton[j, i]}") : carton[j, i])} ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("|");
        Console.ResetColor();
    }
}

Console.ReadKey();
