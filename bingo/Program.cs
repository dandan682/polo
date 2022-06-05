// Programa clase 9 ejercicio 2 - Bingo.

Console.Clear();

string[,] carton = new string[9,3];
Random aleatorio = new Random();
int[] guardaAleatorio = new int[carton.GetLength(1)];
int valorAleatorio = 0;

// Pide al usuario el numero de cartones.
Console.Write("¿Cuantos cartones? ");
int totalCartones = int.Parse(Console.ReadLine());

// Construye los cartones.
for (int c = 0; c < totalCartones; c++)
{
    // Llena los cartones con numeros aleatorios.
    for (int j = 0; j < carton.GetLength(0); j++)
    {
        Array.Clear(guardaAleatorio, 0, guardaAleatorio.Length);
        for (int i = 0; i < carton.GetLength(1); i++)
        {
            // Cicla si encuentra numero repetido.
            valorAleatorio = aleatorio.Next(10 * j + 1, 10 * j + 10);
            while (Array.IndexOf(guardaAleatorio, valorAleatorio) >= 0)
            {
                valorAleatorio = aleatorio.Next(10 * j + 1, 10 * j + 10);
            }
            guardaAleatorio[i] = valorAleatorio;
            carton[j, i] = valorAleatorio.ToString();
        }
    }

    // Mostramos el carton
    Console.WriteLine($"\n\t\t\t\t\t\t\tCarton #{c + 1}");
    Console.Write("\n\t\t\t\t+" + new string('=',52) + "+");
    for (int i = 0; i < carton.GetLength(1); i++)
    {
        Console.Write("\n\t\t\t\t");
        for (int j = 0; j < carton.GetLength(0); j++)
        {
            Console.Write($"| {carton[j, i].PadLeft(2)} |");
        }
        Console.Write("\n\t\t\t\t+" + new string('=', 52) + "+");
    }
    Console.WriteLine();
}

Console.ReadKey();