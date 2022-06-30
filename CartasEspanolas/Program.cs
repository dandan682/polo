using System;
using CartasEspañolas.Modelo;

// Ejercicio clase 14 - Cartas españolas.
var baraja = new Baraja();
int opcion;

Console.Clear();
do
{
    Console.WriteLine("\n\tCARTAS ESPAÑOLAS");
    Console.WriteLine("+--------------------------------+");
    Console.WriteLine("| 1 - Barajar                    |");
    Console.WriteLine("| 2 - Mostrar siguiente carta    |");
    Console.WriteLine("| 3 - Mostrar cartas disponibles |");
    Console.WriteLine("| 4 - Dar cartas                 |");
    Console.WriteLine("| 5 - Mostrar cartas del montón  |");
    Console.WriteLine("| 6 - Mostrar baraja             |");
    Console.WriteLine("| 7 - Salir                      |");
    Console.WriteLine("+--------------------------------+");
    Console.Write("Digite opción: ");
    opcion = Int32.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (opcion)
    {
        case 1:
            baraja.Barajar();
            break;
        case 2:
            baraja.SiguienteCarta();
            break;
        case 3:
            baraja.CartasDisponibles();
            break;
        case 4:
            Console.Write("¿Cuantas cartas quiere? ");
            int numero = Int32.Parse(Console.ReadLine());
            baraja.DarCartas(numero);
            break;
        case 5:
            baraja.CartasMonton();
            break;
        case 6:
            baraja.MostrarBaraja();
            break;
        case 7:
            Console.WriteLine("Fin.");
            break;
        default:
            Console.WriteLine("Opción fuera de rango!!!");
            break;
    }
} while (opcion != 7);