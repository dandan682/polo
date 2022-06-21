using System;
namespace Baraja.Modelo
{
    public class Baraja
    {
        //MIEMBROS
        //Lista de cartas
        List<Carta> baraja = new List<Carta>();
        //Carta
        Carta card;

        //CONSTRUCTOR
        public Baraja()
        {
            //Variables usadas en los for
            int i, j;

            /* 2 bucles for anidados, fuera el de los
             palos que realiza el ciclo 4 veces, por
             12 que hace el de dentro, son las 48 cartas
             de la baraja */
            for (j = 0; j < 4; j++)
            {
                for (i = 0; i < 12; i++)
                {
                    /* Se crea una carta cada vez ya que el valor (i + 1) va de 1 a 12. La primera vez que este bucle se repite
                     las 12 veces, crea todas las cartas del palo 0 que es "Oros". Luego las 12 de "Copas" y así hasta crear
                     todas de todos los palos. */
                    card = new Carta(i + 1, j);
                    //Cada carta creada reescribe la anterior, pero como se añaden a la lista no perdemos esos datos.

                    //Añadimos el objeto recién creado a la lista baraja.
                    baraja.Add(card);
                }
            }
        }

        //MÉTODOS
        //Escribe el número de cartas que hay en la baraja
        public void numeroCartas()
        {
            Console.WriteLine("En la baraja hay " + baraja.Count + " cartas.");
        }

        //Coge la primera carta de la baraja y la elimina de la lista
        public void robaCarta()
        {
            Console.WriteLine("Has robado una carta: ");

            //Se llama al método escribeCarta de la clase carta ya que baraja[0] es un objeto carta
            baraja[0].escribeCarta();

            //Se elimina la carta que hemos escrito por si se roba de nuevo, nos salga la siguiente
            baraja.Remove(baraja[0]);
        }

        //Coge una carta de la posicion indicada por parámetro
        public void cogeCarta(int n)
        {
            /* Es como el método anterior, pero en lugar de operar con la carta baraja[0] se opera con baraja[n] donde
             n es el valor dado a la función */
            Console.WriteLine("Has cogido la carta de la posición: " + n);
            baraja[n].escribeCarta();
            baraja.Remove(baraja[n]);
        }

        //Coge una carta al azar
        public void cogeCartaAlAzar()
        {
            /* Basado en el método anterior pero ahora el valor n es obtenido aleatoriamente, debe ser un valor entre 0 y
             el número de elementos que haya en la lista */
            Random r = new Random();
            int n = r.Next(0, baraja.Count);

            Console.WriteLine("Has cogido una carta al azar: ");
            baraja[n].escribeCarta();
            baraja.Remove(baraja[n]);
        }

        //Escribe todas las cartas que hay en la baraja
        public void escribeBaraja()
        {
            int i;

            //Bucle for para recorrer la lista
            for (i = 0; i < baraja.Count; i++)
            {
                //Escribe la posición de la carta (i + 1)
                //Utilizamos "Write" en lugar de "WriteLine" para que no haga un salto de línea
                Console.Write((i + 1) + ". ");

                //Escribe la carta de la posición i de la lista
                baraja[i].escribeCarta();
            }
        }

        //Mezcla (baraja) las cartas en la lista
        public void Barajar()
        {
            /* Creamos una variable tipo Random y otra int para guardar una posicion aleatoria de 1 a 48 */
            Random r = new Random();
            int posicion;
            int i;

            for (i = 0; i < 48; i++)
            {
                posicion = r.Next(0, 48);
                baraja.Insert(posicion, baraja[0]);
                baraja.Remove(baraja[0]);
            }
        }
    }
}

