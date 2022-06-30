using System;
namespace CartasEspañolas.Modelo
{
    internal class Carta
    {
        string[] palos = { "Espadas", "Bastos", "Oros", "Copas" };
        int numero;
        int palo;
        
        // palos[0] es Espadas
        // palos[1] es Bastos 
        // palos[2] es Oros 
        // palos[3] es Copas

        // CONSTRUCTOR
        // Le pasamos por parámetro el número en la variable n
        // y el palo (valor de 0 a 4) en la variable p
        public Carta(int n, int p)
        {
            numero = n;
            palo = p;
        }

        // MÉTODOS
        public void escribeCarta()
        {
            Console.WriteLine(numero + " de " + palos[palo]);
        }
    }
}