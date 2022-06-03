
Console.Clear();

int[,] carton = new int[9,3];
Random aleatorio = new Random();
int valorAleatorio = 0;
bool repetido = true;

Console.Write("¿Cuantos cartones? ");
int totalCartones = int.Parse(Console.ReadLine());

for (int c = 0; c < totalCartones; c++)
{
    for (int i = 0; i < carton.GetLength(1); i++)
    {
        for (int j = 0; j < carton.GetLength(0); j++)
        {
            do
            {
                valorAleatorio = aleatorio.Next(10 * j, 10 * j + 9);
                repetido = false;
                for (int n = 0; n < i; n++)
                {
                    if (carton[j, n] == valorAleatorio)
                    {
                        repetido = true;
                        break;
                    }
                }
            } while (repetido);
            carton[j, i] = valorAleatorio;
        }
    }

    // Mostramos el carton
    Console.WriteLine($"\n\t\t\t\t\t\t\tCarton #{c + 1}");
    for (int i = 0; i < carton.GetLength(1); i++)
    {
        Console.Write("\n\t\t\t\t");
        for (int j = 0; j < carton.GetLength(0); j++)
        {
            Console.Write("|");
            Console.Write($" {(carton[j, i] < 10 ? (carton[j, i] == 0 ? "&&" : $"0{carton[j, i]}") : carton[j, i])} ");
            Console.Write("|");
        }
    }
    Console.WriteLine();
}

Console.ReadKey();
