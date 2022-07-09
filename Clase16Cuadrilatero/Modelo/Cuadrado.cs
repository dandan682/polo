using System;
namespace Clase16Cuadrilatero.Modelo
{
    public class Cuadrado : Cuadrilatero
    {
        public Cuadrado(float valor1X, float valor1Y, float valor2X, float valor2Y, float valor3X, float valor3Y, float valor4X, float valor4Y) : base(valor1X, valor1Y, valor2X, valor2Y, valor3X, valor3Y, valor4X, valor4Y) { }
            
        public override float CalcularArea()
        {
            float lado = Distancia2Puntos(Vertice1X, Vertice1Y, Vertice2X, Vertice2Y);

            return lado * lado;
        }
    }
}

