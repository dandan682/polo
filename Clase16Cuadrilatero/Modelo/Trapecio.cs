using System;
namespace Clase16Cuadrilatero.Modelo
{
    public class Trapecio: Cuadrilatero
    {
        public Trapecio(float valor1X, float valor1Y, float valor2X, float valor2Y, float valor3X, float valor3Y, float valor4X, float valor4Y) : base(valor1X, valor1Y, valor2X, valor2Y, valor3X, valor3Y, valor4X, valor4Y) { }

        public override float CalcularArea()
        {
            float lado1 = Distancia2Puntos(Vertice1X, Vertice1Y, Vertice2X, Vertice2Y);
            float lado2 = Distancia2Puntos(Vertice2X, Vertice2Y, Vertice3X, Vertice3Y);
            float lado3 = Distancia2Puntos(Vertice3X, Vertice3Y, Vertice4X, Vertice4Y);
            float lado4 = Distancia2Puntos(Vertice4X, Vertice4Y, Vertice1X, Vertice1Y);

            float area = ((lado1 + lado2) / 2) * (float)Math.Sqrt(Math.Pow(lado3, 2) - Math.Pow((Math.Pow(lado3, 2) - Math.Pow(lado4, 2) + Math.Pow(lado1 - lado2, 2)) / (2 * (lado1 - lado2)), 2));

            return area;
        }
    }
}