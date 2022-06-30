using System;
using Barajas.Modelo;

Console.Clear();

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
