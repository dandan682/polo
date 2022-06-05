// Programa clase 9 ejercicio 2 - Bingo.

Console.Clear();

int[,] carton = new int[9,3];
Random aleatorio = new Random();
int valorAleatorio = 0;
bool repetido;

// Pide al usuario el numero de cartones.
Console.Write("¿Cuantos cartones? ");
int totalCartones = int.Parse(Console.ReadLine());

// Construye los cartones.
for (int c = 0; c < totalCartones; c++)
{
    // Llena los cartones con numeros aleatorios.
    for (int i = 0; i < carton.GetLength(1); i++)
    {
        for (int j = 0; j < carton.GetLength(0); j++)
        {
            // Cicla si se trata de un numero repetido.
            do
            {
                // Nuevo numero aleatorio en rango de la columna correspondiente.
                valorAleatorio = aleatorio.Next(10 * j, 10 * j + 9);
                // Valida numero repetido.
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
    Console.Write("\n\t\t\t\t+" + new string('=',52) + "+");
    for (int i = 0; i < carton.GetLength(1); i++)
    {
        Console.Write("\n\t\t\t\t");
        for (int j = 0; j < carton.GetLength(0); j++)
        {
            Console.Write("|");
            if (carton[j, i] == 0)
            {
                Console.Write(" && ");
            }
            else
            {
                Console.Write($" {carton[j, i].ToString("D2")} ");
            }
            Console.Write("|");
        }
        Console.Write("\n\t\t\t\t+" + new string('=', 52) + "+");
    }
    Console.WriteLine();
}

Console.ReadKey();