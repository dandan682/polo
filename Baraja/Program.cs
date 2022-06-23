using System;

namespace Baraja
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
            baraja.escribeBaraja();
            baraja.Barajar();
            baraja.escribeBaraja();
            baraja.robaCarta();
            baraja.cogeCarta(5);
            baraja.cogeCartaAlAzar();
            baraja.numeroCartas();

            Console.ReadKey();
        }
    }
}