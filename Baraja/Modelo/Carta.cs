using System;
namespace Baraja.Modelo
{
    public class Carta
    {

        //MIEMBROS
        int numero;
        int palo;
        string[] palos = { "Oros", "Copas", "Espadas", "Bastos" };

        /*
        palos[0] es Oros
        palos[1] es Copas
        palos[2] es Espadas
        palos[3] es Bastos
        */

        //CONSTRUCTOR
        /* Le pasamos por parámetro el número en la variable n
        y el palo (valor de 0 a 4) en la variable p */
        public Carta(int n, int p)
        {
            /* Se asignan los valores pasados a los
            miembros propios de la clase (objeto) */
            numero = n;
            palo = p;
        }

        //MÉTODOS O FUNCIONES
        /* Este método escribe el valor de la carta actual */
        public void escribeCarta()
        {
            Console.WriteLine(numero + " de " + palos[palo]);
        }
    }
}