using System;
namespace Barajas.Modelo
{
    public class Baraja
    {
        //Lista de cartas
        List<Carta> baraja = new List<Carta>();

        //Lista de monton
        List<Carta> monton = new List<Carta>();

        //Carta
        Carta card;

        //CONSTRUCTOR
        public Baraja()
        {
            //Variables usadas en los for
            // int i, j;

            /* 2 bucles for anidados, fuera el de los
             palos que realiza el ciclo 4 veces, por
             12 que hace el de dentro, son las 48 cartas
             de la baraja */
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 12; i++)
                {
                    /* Se crea una carta cada vez ya que el valor (i + 1) va de 1 a 12. La primera vez que este bucle se repite
                     las 12 veces, crea todas las cartas del palo 0 que es "Oros". Luego las 12 de "Copas" y así hasta crear
                     todas de todos los palos. */

                    // Elimina carta numero 8 y 9 
                    if ((i == 7) | (i == 8)) {
                        continue;
                    }

                    card = new Carta(i + 1, j);
                    //Cada carta creada reescribe la anterior, pero como se añaden a la lista no perdemos esos datos.

                    //Añadimos el objeto recién creado a la lista baraja.
                    baraja.Add(card);
                }
            }
        }

        //Escribe el número de cartas que hay en la baraja
        public void CartasDisponibles()
        {
            Console.WriteLine("En la baraja hay " + baraja.Count + " cartas.");
        }

        //Coge la primera carta de la baraja, la agrega al monton y la elimina de la lista.
        public void SiguienteCarta()
        {
            Console.WriteLine("Has robado una carta: ");

            //Se llama al método escribeCarta de la clase carta ya que baraja[0] es un objeto carta
            baraja[0].escribeCarta();

            //Se adiciona la carta al monton
            monton.Add(baraja[0]);

            //Se elimina la carta que hemos escrito por si se roba de nuevo, nos salga la siguiente
            baraja.Remove(baraja[0]);
        }

        // Dar n cartas
        public void DarCartas(int n)
        {
            if (n <= baraja.Count)
            {
                Console.WriteLine("Cartas solicitadas: " + n);
                for (int i = 0; i < n; i++)
                {
                    Console.Write("carta: " + i + " ");
                    baraja[0].escribeCarta();
                    monton.Add(baraja[0]);
                    baraja.Remove(baraja[0]);
                    CartasDisponibles();
                }
            }
           else
            {
                Console.WriteLine("Hay menos cartas de las solicitadas!!!");
            }
        }

        //Escribe todas las cartas que hay en la baraja
        public void MostrarBaraja()
        {
            //Bucle for para recorrer la lista
            Console.WriteLine("Total cartas mazo: " + baraja.Count);
            for (int i = 0; i < baraja.Count; i++)
            {
                //Escribe la posición de la carta (i + 1)
                //Utilizamos "Write" en lugar de "WriteLine" para que no haga un salto de línea
                Console.Write((i + 1) + ". ");

                //Escribe la carta de la posición i de la lista
                baraja[i].escribeCarta();
            }
        }

        //Escribe todas las cartas que hay en la baraja
        public void CartasMonton()
        {
            //Bucle for para recorrer la lista
            Console.WriteLine("Total cartas monton: " + monton.Count);
            for (int i = 0; i < monton.Count; i++)
            {
                //Escribe la posición de la carta (i + 1)
                //Utilizamos "Write" en lugar de "WriteLine" para que no haga un salto de línea
                Console.Write((i + 1) + ". ");

                //Escribe la carta de la posición i de la lista
                monton[i].escribeCarta();
            }
        }

        //Mezcla (baraja) las cartas en la lista
        public void Barajar()
        {
            /* Creamos una variable tipo Random y otra int para guardar una posicion aleatoria de 1 a 48 */
            Random r = new Random();
            int posicion;
            int i;

            Console.WriteLine("Total de cartas: " + baraja.Count);
            for (i = 0; i < baraja.Count; i++)
            {
                posicion = r.Next(0, baraja.Count);
                Console.WriteLine($"posicion: {posicion}");
                baraja.Insert(posicion, baraja[0]);
                baraja.Remove(baraja[0]);
            }
        }
    }
}