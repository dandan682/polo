// Programa ejercicio 1 de la clase 9.
Console.Clear();

// Pide al usuario la longitud del vector.
Console.Write("Escriba la longitud del vector: ");
int vectorLongitud = int.Parse(Console.ReadLine());

// Define el vector numeros.
int[] numeros = new int[vectorLongitud];

// Crea variable aleatorio.
Random aleatorio = new Random();

// Llena el vector con numeros aleatorios maximo 100.
for (int n = 0; n < numeros.Length; n++)
{
    numeros[n] = aleatorio.Next(100);
}

// Muestra el vector original.
Console.WriteLine("\nVector original de aleatorios.");
foreach(var n in numeros)
{
    Console.Write($"{n}\t");
}

// Invierte el vector.
int aux = 0;
int m = numeros.Length - 1;
for (int n = 0; n < numeros.Length / 2; n++)
{
    aux = numeros[n];
    numeros[n] = numeros[m];
    numeros[m--] = aux;
}

// Muestra el vector invertido.
Console.WriteLine("\nVector Invertido de aleatorios.");
foreach (var n in numeros)
{
    Console.Write($"{n}\t");
}

Console.ReadKey();