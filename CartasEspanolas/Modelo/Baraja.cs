using System;
namespace CartasEspañolas.Modelo
{
    internal class Baraja
    {
        //Lista de cartas
        List<Carta> baraja = new List<Carta>();

        //Lista de monton
        List<Carta> monton = new List<Carta>();

        //Carta
        Carta card;

        // CONSTRUCTOR
        public Baraja()
        {

            // Dos bucles for anidados. Primero para palos. Segundo para las cartas.
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 12; i++)
                {
                    // Elimina cartas 8 y 9.
                    if ((i == 7) | (i == 8))
                    {
                        continue;
                    }

                    // Crea nuevo objeto carta.
                    card = new Carta(i + 1, j);

                    // Añadimos el objeto recién creado a la lista baraja.
                    baraja.Add(card);
                }
            }
        }

        // Escribe el número de cartas que hay en la baraja.
        public void CartasDisponibles()
        {
            Console.WriteLine($"En la baraja hay {baraja.Count} cartas.");
        }

        // Coge la primera carta de la baraja, la agrega al monton y la elimina de la lista.
        public void SiguienteCarta()
        {
            if (baraja.Count == 0)
            {
                Console.WriteLine("No hay más cartas.");
            }
            else
            {
                baraja[0].escribeCarta();

                // Se adiciona la carta al montón.
                monton.Add(baraja[0]);
                // Se elimina la carta que hemos escrito.
                baraja.Remove(baraja[0]);

                if (baraja.Count == 0)
                {
                    Console.WriteLine("\nEsta fue la última carta, ya no hay más.");
                }
            }
        }

        // Dar n cartas
        public void DarCartas(int n)
        {
            if (n <= baraja.Count)
            {
                Console.WriteLine($"\nCartas solicitadas: {n}\n");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{i + 1}. ");
                    baraja[0].escribeCarta();
                    // Adiciona la carta al montón.
                    monton.Add(baraja[0]);
                    // Quita carta de la baraja.
                    baraja.Remove(baraja[0]);
                }
            }
            else
            {
                Console.WriteLine("\nHay menos cartas de las solicitadas!!!");
            }
        }

        // Escribe todas las cartas que hay en la baraja
        public void MostrarBaraja()
        {
            //Bucle para recorrer la lista baraja.
            if (baraja.Count == 0)
            {
                Console.WriteLine("No hay cartas en la baraja.");
            }
            else
            {
                for (int i = 0; i < baraja.Count; i++)
                {
                    Console.Write($"{(i + 1)}. ");
                    baraja[i].escribeCarta();
                }
            }
        }

        // Escribe todas las cartas que hay en el montón
        public void CartasMonton()
        {
            // Bucle para recorrer la lista montón.
            if (monton.Count == 0)
            {
                Console.WriteLine("No hay cartas en el montón.");
            }
            else
            {
                for (int i = 0; i < monton.Count; i++)
                {
                    Console.Write($"{(i + 1)}. ");
                    monton[i].escribeCarta();
                }
            }
        }

        //Mezcla baraja
        public void Barajar()
        {
            // Creamos una variable tipo Random
            Random r = new Random();
            int posicion;

            // Posición aleatoria entre 0 y el numero de cartas en el mazo.
            // Inserta carta en posición.
            for (int i = 0; i < baraja.Count; i++)
            {
                posicion = r.Next(0, baraja.Count);
                baraja.Insert(posicion, baraja[0]);
                baraja.Remove(baraja[0]);
            }
        }
    }
}