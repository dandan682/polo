// Programa clase 9 ejercicio 2 - Bingo.

Console.Clear();

string[,] carton = new string[3,9];
Random crearAleatorio = new Random();
int valorAleatorio;

// Array para evitar duplicados.
string[] guardarAleatorio = new string[carton.GetLength(0)]; 

// Pide al usuario el numero de cartones.
Console.Write("¿Cuantos cartones? ");
int totalCartones = int.Parse(Console.ReadLine());

// Ciclo del set de cartones.
for (int c = 0; c < totalCartones; c++)
{
    // Inicia ciclo del carton[c] para llenarlo de numeros aleatorios.
    for (int columna = 0; columna < carton.GetLength(1); columna++)
    {
        Array.Clear(guardarAleatorio, 0, guardarAleatorio.Length);
        for (int fila = 0; fila < carton.GetLength(0); fila++)
        {
            valorAleatorio = regresaAleatorio(guardarAleatorio, 10 * columna + 1, 10 * columna + 10);
            // Pone numero aleatorio.
            carton[fila, columna] = valorAleatorio.ToString();
            guardarAleatorio[fila] = valorAleatorio.ToString();
        }
    }
    // Termina ciclo del carton[c] con numeros aleatorios.

    // Inicia ciclo para colocar 12 espacios en blanco al carton.
    string[] vacios = new string[12];
    int filaEspacio;
    int v = 0;

    for (int n = 0; n < vacios.Length; n++)
    {
        valorAleatorio = regresaAleatorio(vacios, 0, 9);
        filaEspacio = n / 4;
        carton[filaEspacio, valorAleatorio] = " ";
        if (n == 8)
        {           
            Array.Clear(vacios, 0, vacios.Length);
            v = 0;
        }
        vacios[v++] = valorAleatorio.ToString();
    }
    // Termina ciclo espacios en blanco.

    // Imprime en pantalla el carton.
    Console.WriteLine($"\n"   + new string(' ',52) + $"Carton #{c + 1}");
    Console.Write("\n\t\t\t+" + new string('=',62) + "+");

    for (int fila = 0; fila < carton.GetLength(0); fila++)
    {
        Console.Write("\n\t\t\t|");
        for (int columna = 0; columna < carton.GetLength(1); columna++)
        {
            Console.Write($"  {carton[fila, columna].PadLeft(2)}  |");
        }
        Console.Write("\n\t\t\t+" + new string('=', 62) + "+");
    }
    Console.WriteLine();
}

Console.ReadKey();

// Funcion regresaAleatorio: devuelve un único numero aleatorio.
int regresaAleatorio(string[] vector, int minimo, int maximo)
{
    valorAleatorio = crearAleatorio.Next(minimo, maximo);
    // Cicla mientras numero repetido.
    while (Array.IndexOf(vector, valorAleatorio.ToString()) >= 0)
    {
        valorAleatorio = crearAleatorio.Next(minimo, maximo);
    }
    return valorAleatorio;
}