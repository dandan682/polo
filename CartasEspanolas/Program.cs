using System;
using CartasEspañolas.Modelo;

var baraja = new Baraja();
int opcion;

Console.Clear();
do
{
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
    Console.ReadLine();

    switch (opcion)
    {

    }
} while 

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

Console.ReadKey();

