// Tarea clase 9 ejercicio 2 - Bingo.

string[,] carton = new string[3,9];
Random crearAleatorio = new Random();
int valorAleatorio;

// Array para evitar duplicados.
string[] guardarAleatorios = new string[carton.GetLength(0)];

// Array para 12 espacios en blanco.
string[] guardarEspacios = new string[12];

Console.Clear();

// Construye un juego de 4 cartones.
do
{
    for (int c = 0; c < 4; c++) {

        // Ciclo llenado de carton con numeros aleatorios.
        for (int columna = 0; columna < carton.GetLength(1); columna++)
        {
            inicializarArray(guardarAleatorios);
            for (int fila = 0; fila < carton.GetLength(0); fila++)
            {
                // Numero aleatorio para columna 0 va de 1 a 9. Para columna 8 va de 80 a 90.
                valorAleatorio = buscarAleatorio(guardarAleatorios, columna * 10 + 1 / (columna + 1), columna * 10 + 10 + (columna / 8));
                // Asigna el numero.
                carton[fila, columna]   = valorAleatorio.ToString();
                guardarAleatorios[fila] = valorAleatorio.ToString();
            }
        }

        // Ordena el carton.
        ordenar(carton);

        // Ciclo colocar 12 espacios en blanco.
        inicializarArray(guardarEspacios);
        for (int espacio = 0; espacio < guardarEspacios.Length; espacio++)
        {
            // Escoge aleatoriamente columnas 0 al 8 para filas 1 y 2.
            valorAleatorio = buscarAleatorio(guardarEspacios, 0, 9);
            if (espacio == 8)
            {
                // Para fila 3 prepara otras columnas 0 al 8.
                inicializarArray(guardarEspacios);
            }
            int filaCarton = espacio / 4;
            carton[filaCarton, valorAleatorio] = " ";
            guardarEspacios[espacio] = valorAleatorio.ToString();
        }

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
    Console.WriteLine("\n\n¿Otro juego? (s/n)");
}
while (Console.ReadLine().ToLower() != "n");

// Funcion para regresar un numero aleatorio unico.
int buscarAleatorio(string[] vector, int minimo, int maximo)
{
    valorAleatorio = crearAleatorio.Next(minimo, maximo);
    // Cicla mientras numero repetido.
    while (existeValor(vector, valorAleatorio.ToString()))
    {
        valorAleatorio = crearAleatorio.Next(minimo, maximo);
    }
    return valorAleatorio;
}

// Funcion para saber si ya existe el valor en el array.
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
void inicializarArray (string[] vector)
{
    for (int i = 0; i < vector.Length; i++)
    {
        vector[i] = " ";
    }
    return;
}

// Funcion para ordenar el carton de forma ascendente.
void ordenar (string[,] carton)
{
    for (int columna = 0; columna < carton.GetLength(1); columna++)
    {
        for (int x = 0; x < carton.GetLength(0); x++)
        {
            for (int indiceActual = 0; indiceActual < carton.GetLength(0) - 1;
                 indiceActual++)
            {
                int indiceSiguiente = indiceActual + 1;
                // Si el actual es mayor que el que le sigue a la derecha...
                if (int.Parse(carton[indiceActual, columna]) > int.Parse(carton[indiceSiguiente, columna]))
                {
                    string temporal = carton[indiceActual, columna];
                    carton[indiceActual, columna] = carton[indiceSiguiente, columna];
                    carton[indiceSiguiente, columna] = temporal;
                }
            }
        }
    }
    return;
}