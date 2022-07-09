using Clase16Cuadrilatero.Modelo;

Console.Clear();
Console.WriteLine("\nPrograma que calcula el área de un trapecio, un rectángulo y un cuadrado.");

int opcion;
do
{
    Console.WriteLine("\nElija una opción:\n");
    Console.WriteLine("1 - Área de un trapecio");
    Console.WriteLine("2 - Área de un rectángulo");
    Console.WriteLine("3 - Área de un cuadrado");
    Console.WriteLine("4 - Salir");
    Console.WriteLine();

    opcion = int.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (opcion)
    {
        case 1:
        case 2:
        case 3:
            Console.WriteLine("A continuación proporcione los 4 vértices que forman el cuadrilátero.\n");

            Console.Write("Vértice    uno, ingrese valor de x: ");
            int valor1X = int.Parse(Console.ReadLine());
            Console.Write("Vértice    uno, ingrese valor de y: ");
            int valor1Y = int.Parse(Console.ReadLine());

            Console.Write("Vértice    dos, ingrese valor de x: ");
            int valor2X = int.Parse(Console.ReadLine());
            Console.Write("Vértice    dos, ingrese valor de y: ");
            int valor2Y = int.Parse(Console.ReadLine());

            Console.Write("Vértice   tres, ingrese valor de x: ");
            int valor3X = int.Parse(Console.ReadLine());
            Console.Write("Vértice   tres, ingrese valor de y: ");
            int valor3Y = int.Parse(Console.ReadLine());

            Console.Write("Vértice cuatro, ingrese valor de x: ");
            int valor4X = int.Parse(Console.ReadLine());
            Console.Write("Vértice cuatro, ingrese valor de y: ");
            int valor4Y = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Trapecio Trapecio = new Trapecio(valor1X, valor1Y, valor2X, valor2Y, valor3X, valor3Y, valor4X, valor4Y);
                    Console.WriteLine("\nEl área del trapecio es: " + Trapecio.CalcularArea());
                    break;

                case 2:
                    Rectangulo Rectangulo = new Rectangulo(valor1X, valor1Y, valor2X, valor2Y, valor3X, valor3Y, valor4X, valor4Y);
                    Console.WriteLine("\nEl área del rectángulo es: " + Rectangulo.CalcularArea());
                    break;

                case 3:
                    Cuadrado Cuadrado = new Cuadrado(valor1X, valor1Y, valor2X, valor2Y, valor3X, valor3Y, valor4X, valor4Y);
                    Console.WriteLine("\nEl área del cuadrado es: " + Cuadrado.CalcularArea());
                    break;
            }
            break;

        case 4:
            break;
        default:
            Console.WriteLine("Opción inválida!");
            break;
    }
} while (opcion != 4);
Console.WriteLine("Fin!");