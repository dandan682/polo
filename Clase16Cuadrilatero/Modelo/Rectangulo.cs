using System;
namespace Clase16Cuadrilatero.Modelo
{
    public class Rectangulo: Cuadrilatero
    {
        public Rectangulo(float valor1X, float valor1Y, float valor2X, float valor2Y, float valor3X, float valor3Y, float valor4X, float valor4Y) : base(valor1X, valor1Y, valor2X, valor2Y, valor3X, valor3Y, valor4X, valor4Y) { }

        public override float CalcularArea()
        {
            float lado1 = Distancia2Puntos(Vertice1X, Vertice1Y, Vertice2X, Vertice2Y);
            float lado2 = Distancia2Puntos(Vertice2X, Vertice2Y, Vertice3X, Vertice3Y);

            return lado1 * lado2;
        }
    }
}