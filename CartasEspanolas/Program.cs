using System;
using CartasEspañolas.Modelo;

var baraja = new Baraja();
int opcion;
bool salir;

Console.Clear();
do
{
    salir = false;
    Console.WriteLine();
    Console.WriteLine("**********************************");
    Console.WriteLine("* 1 - Barajar                    *");
    Console.WriteLine("* 2 - Mostrar siguiente carta    *");
    Console.WriteLine("* 3 - Mostrar cartas disponibles *");
    Console.WriteLine("* 4 - Dar cartas                 *");
    Console.WriteLine("* 5 - Mostrar cartas del montón  *");
    Console.WriteLine("* 6 - Mostrar baraja             *");
    Console.WriteLine("* 7 - Salir                      *");
    Console.WriteLine("**********************************");
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
            salir = true;
            Console.WriteLine("Salida...");
            break;
        default:
            Console.WriteLine("Opción fuera de rango.");
            break;
    }
} while (!salir);

/**
baraja.MostrarBaraja();
baraja.Barajar();
baraja.MostrarBaraja();
baraja.SiguienteCarta();
baraja.CartasMonton();
// baraja.cogeCarta(5);
baraja.CartasDisponibles();
baraja.DarCartas(10);
// baraja.cogeCartaAlAzar();
baraja.CartasDisponibles();
baraja.MostrarBaraja();
baraja.CartasMonton();
**/