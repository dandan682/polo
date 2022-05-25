// Programa que pedira al ususario 10 numeros enteros.
// Calculara la suma, el promedio, el mayor y menor de los numeros.
// Mostrara los resultados obtenidos.

Console.Clear();

int totalNumeros = 10;
int[] numeros = new int[totalNumeros];
int suma  = 0;

Console.WriteLine($"*** Favor de introducir {totalNumeros} numeros enteros ***");

// Pide los numeros y va sumando
for(int i = 0; i < totalNumeros; i++)
{
    Console.Write($"Escribe numero [{i+1}]: ");
    numeros[i] = int.Parse(Console.ReadLine());
    suma += numeros[i];
}

int mayor = numeros[0];
int menor = numeros[0];

// Calcula el promedio de los numeros
float promedio = (float)suma / totalNumeros;

// Obtiene el numero mayor y menor
for (int i = 0; i < totalNumeros; i++)
{
    if (numeros[i] > mayor)
        mayor = numeros[i];
    else if (numeros[i] < menor)
        menor = numeros[i];
}

// Escribe resultados
Console.WriteLine();
Console.Write("Numeros introducidos por el usuario: ");
for (int i = 0; i < totalNumeros; i++)
{
    Console.Write($"{numeros[i]} ");
}
Console.WriteLine();
Console.WriteLine($"Suma de los numeros: {suma}");
Console.WriteLine($"Promedio de los numeros: {promedio}");
Console.WriteLine($"El mayor de los numeros: {mayor}");
Console.WriteLine($"El menor de los numeros: {menor}");

Console.ReadKey();