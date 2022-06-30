using System;
using Barajas.Modelo;

namespace Barajas
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Creamos una baraja, ya no necesitamos crear cartas, pues en el constructor del objeto baraja se
             crean las 48 cartas de la baraja */
            Baraja baraja = new Baraja();

            /* Llamamos a los métodos como queramos, os dejo esta secuencia, pero jugad con el orden y valores para ver
            otros resultados */
            baraja.MostrarBaraja();
            baraja.Barajar();
            baraja.MostrarBaraja();
            baraja.SiguienteCarta();
            // baraja.cogeCarta(5);
            baraja.CartasDisponibles();
            baraja.DarCartas(39);
            // baraja.cogeCartaAlAzar();
            baraja.CartasDisponibles();

            Console.ReadKey();
        }
    }
}