// See https://aka.ms/new-console-template for more information
Console.Clear();

Console.WriteLine("Este programa calcula la superficie de un rectangulo");
Console.WriteLine();

Console.WriteLine("Ingrese la base del rectangulo: ");
double baseRectangulo = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la altura del rectangulo: ");
double alturaRectangulo = double.Parse(Console.ReadLine());

double superficieRectangulo = baseRectangulo * alturaRectangulo;

Console.Write("La superficie del rectangulo es: ");
Console.WriteLine(superficieRectangulo);

Console.ReadKey();
