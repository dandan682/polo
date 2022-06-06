// Tarea clase 9 ejercicio 2 - Bingo.

Console.Clear();

string[,] carton = new string[3,9];
Random crearAleatorio = new Random();
int valorAleatorio;
int incremento;

// Array para evitar duplicados.
string[] guardarAleatorio = new string[carton.GetLength(0)]; 

// Ciclo set de cartones.
do
{
    for (int c = 0; c < 4; c++) {
        // Inicia ciclo llenar carton de numeros aleatorios.
        for (int columna = 0; columna < carton.GetLength(1); columna++)
        {
            incremento = columna == 0 ? 1 : 0;
            iniciaArray(guardarAleatorio);
            for (int fila = 0; fila < carton.GetLength(0); fila++)
            {
                valorAleatorio = regresaAleatorio(guardarAleatorio, columna * 10 + incremento, columna * 10 + 10 + (columna / 8));
                // Pone numero aleatorio.
                carton[fila, columna] = valorAleatorio.ToString();
                guardarAleatorio[fila] = valorAleatorio.ToString();
            }
        }
        // Termina ciclo llenado del carton.

        // Inicia ciclo colocar 12 espacios en blanco en el carton.
        string[] vacios = new string[12];
        int filaEspacio;
        int v = 0;

        for (int e = 0; e < vacios.Length; e++)
        {
            valorAleatorio = regresaAleatorio(vacios, 0, 9);
            filaEspacio = e / 4;
            carton[filaEspacio, valorAleatorio] = " ";
            if (e == 8)
            {
                iniciaArray(vacios);
                v = 0;
            }
            vacios[v++] = valorAleatorio.ToString();
        }
        // Termina ciclo espacios en blanco.

        // Imprime en pantalla el carton.
        Console.WriteLine();
        Console.Write("\n+" + new string('-', 62) + "+"); 
        for (int fila = 0; fila < carton.GetLength(0); fila++)
        {
            Console.Write("\n|");
            for (int columna = 0; columna < carton.GetLength(1); columna++)
            {
                Console.Write($"  {carton[fila, columna].PadLeft(2)}  |");
            }
        }
        Console.Write("\n+" + new string('-', 62) + "+");
    }
    Console.WriteLine("\n\n¿Otro carton (s/n)?");
}
while (Console.ReadLine().ToLower() != "n");

// Funcion para regresar un numero aleatorio unico.
int regresaAleatorio(string[] vector, int minimo, int maximo)
{
    valorAleatorio = crearAleatorio.Next(minimo, maximo);
    // Cicla mientras numero repetido.
    while (existeValor(vector, valorAleatorio.ToString()))
    {
            valorAleatorio = crearAleatorio.Next(minimo, maximo);
    }
    return valorAleatorio;
}

// Funcion para regresar existencia de un valor en un array.
bool existeValor (string[] vector, string valor)
{
    bool encontrado = false;
    foreach (string elemento in vector)
    {
        if (elemento == valor)
        {
            encontrado = true;
            break;
        }
    }
    return encontrado;
}

// Funcion para inicializar con espacios un array de tipo string
void iniciaArray (string[] vector)
{
    for (int i = 0; i < vector.Length; i++)
    {
        vector[i] = " ";
    }
    return;
}