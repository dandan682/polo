// See https://aka.ms/new-console-template for more information

// Creo un metodo para crear muchos cartones de una :)
void crearCartonesBingo(int cartones)
{   // este for es solo para crear un nuevo carton tantas veces como el parametro cartones lo indique.
    for (int h = 0; h < cartones; h++)
    // todo lo que esta aca adentro es el codigo para crear el carton.
    {
        // Creo la matriz(carton de bingo) con 9 columnas y 3 filas.
        int[,] carton = new int[9, 3];

        // instancio la clase Random en la variable "aleatorio".
        Random aleatorio = new Random();

        // Creo un array de 15 posiciones (la cantidad de numeros que tiene un carton)
        // para guardar los numeros que vayan saliendo con el fin de evaluar que no se repitan.
        int[] numerosCarton = new int[15];

        for (int i = 0; i < 15; i++)
        {
            // Guardo un numero aleatorio entre 0 y 8 (Son 9 columnas o 9 posiciones: 0,1,2...8,9)
            int randomColumna = aleatorio.Next(9);
            // Guardo un numero aleatorio entre 0 y 2 (Son 3 filas o 3 posiciones: 0, 1 y 2)
            int randomFila = aleatorio.Next(3);
            // Creo un numero aleatorio entre 1 y 99.
            int numeroAleatorio = aleatorio.Next(0, 100);

            // Evaluamos si el numero aleatorio ya fue utilizado valiendome del array numerosCarton y el metodo Contains.
            // Si el numero aleatorio ya fue guardado se crea otro hasta que no haya coincidencia.
            while (numerosCarton.Contains(numeroAleatorio))
            {
                numeroAleatorio = aleatorio.Next(100);
            }

            // Evaluamos si el numero de la matriz en la posicion X(columna aleatoria)
            // y la posicion Y(fila aleatoria) no sea igual a 0.

            // Si no es igual a 0, quiere decir que esa posicion ya esta ocupada por un numero distinto de 0
            // es decir, un numero aleatorio.

            // Por lo tanto para no sobreescribir esta posicion cambiamos el numero aleatorio de columnas y filas
            // y lo volvemos a evaluar hasta que encontremos una posición en 0.
            while (carton[randomColumna, randomFila] != 0)
            {
                randomColumna = aleatorio.Next(9);
                randomFila = aleatorio.Next(3);
            }
            // Si la evaluación de arriba es igual a 0 quiere decir que allí no hay ningún numero asignado
            // por lo tanto podemos utilizar esa posición en la matriz para guardar nuestro numero aleatorio.
            carton[randomColumna, randomFila] = numeroAleatorio;

            // Agregamos nuestro numero aleatorio al array para evaluar en la próxima iteración y evitar
            // numeros repetidos.
            numerosCarton[i] = numeroAleatorio;
        }


        // Mostramos el carton ;)
        for (int i = 0; i < carton.GetLength(1); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < carton.GetLength(0); j++)
            {
                Console.Write($"| {carton[j, i].ToString("D2")} |");
            }
        }

        Console.WriteLine();
    }
}

// Llamada al metodo. Pasandole 5 como parametro. Esto creara 5 cartones!
crearCartonesBingo(5);
