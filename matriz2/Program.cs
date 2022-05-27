// Programa ejercicio de la clase 8.

Console.Clear();

// Pide al usuario los numeros de las filas y las columnas de la matriz numeros.
Console.Write("Escriba numero de filas: ");
int filas = int.Parse(Console.ReadLine());

Console.Write("Escriba numero de columnas: ");
int cols = int.Parse(Console.ReadLine());

// Define la matriz numeros.
int[,] numeros = new int[filas, cols];

// Calcula el tamaño de la matriz numeros.
int lengthFilas = numeros.GetUpperBound(0) + 1;
int lengthCols  = numeros.GetUpperBound(1) + 1;

// Define el vector promedios.
double[] promedios = new double[lengthCols];

// Calcula el tamaño del vector promedios.
int lengthPromedios = promedios.GetUpperBound(0) + 1;

// Llena la matriz numeros con los valores proporcionados por el usuario.
for (int f = 0; f < lengthFilas; f++)
{
    for (int c = 0; c < lengthCols; c++)
    {
        Console.Write($"Escriba el valor [{f + 1}][{c + 1}]: ");
        numeros[f, c] = int.Parse(Console.ReadLine());
    }
}

// Escribe en pantalla la matriz numeros.
Console.WriteLine("\nValores de la matriz numeros");
for (int f = 0; f < lengthFilas; f++)
{
    Console.WriteLine();
    for (int c = 0; c < lengthCols; c++)
    {
        Console.Write($"{numeros[f, c]}\t");
    }
}

// Llena vector promedios.
double suma = 0;
for (int c = 0; c < lengthCols; c++)
{
    suma = 0;
    for (int f = 0; f < lengthFilas; f++)
    {
        suma += numeros[f, c];
    }
    promedios[c] = suma / lengthFilas;
}

// Escribe en pantalla el vector promedios.
Console.WriteLine("\n\nPromedio de cada columna de la matriz numeros\n");
for (int c = 0; c < lengthPromedios; c++)
{
    Console.Write($"{promedios[c]}\t");
}

Console.ReadKey();