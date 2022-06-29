using System;
namespace Barajas.Modelo
{
    public class Carta
    {
        int numero;
        int palo;
        // string[] palos = { "Oros", "Copas", "Espadas", "Bastos" };
        string[] palos = { "Espadas", "Bastos", "Oros", "Copas" };

        /*
        palos[0] es Espadas
        palos[1] es Bastos 
        palos[2] es Oros 
        palos[3] es Copas
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