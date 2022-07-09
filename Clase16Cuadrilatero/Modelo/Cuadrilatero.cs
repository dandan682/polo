using System;
namespace Clase16Cuadrilatero.Modelo
{
    public abstract class Cuadrilatero
    {
        private float _vertice1X;
        private float _vertice1Y;
        private float _vertice2X;
        private float _vertice2Y;
        private float _vertice3X;
        private float _vertice3Y;
        private float _vertice4X;
        private float _vertice4Y;


        public float Vertice1X { get => _vertice1X; set => _vertice1X = value; }
        public float Vertice1Y { get => _vertice1Y; set => _vertice1Y = value; }
        public float Vertice2X { get => _vertice2X; set => _vertice2X = value; }
        public float Vertice2Y { get => _vertice2Y; set => _vertice2Y = value; }
        public float Vertice3X { get => _vertice3X; set => _vertice3X = value; }
        public float Vertice3Y { get => _vertice3Y; set => _vertice3Y = value; }
        public float Vertice4X { get => _vertice4X; set => _vertice4X = value; }
        public float Vertice4Y { get => _vertice4Y; set => _vertice4Y = value; }

        public Cuadrilatero(float vertice1X, float vertice1Y,
                            float vertice2X, float vertice2Y,
                            float vertice3X, float vertice3Y,
                            float vertice4X, float vertice4Y)
        {
            Vertice1X = vertice1X;
            Vertice1Y = vertice1Y;
            Vertice2X = vertice2X;
            Vertice2Y = vertice2Y;
            Vertice3X = vertice3X;
            Vertice3Y = vertice3Y;
            Vertice4X = vertice4X;
            Vertice4Y = vertice4Y;
        }

        public abstract float CalcularArea();

        public float Distancia2Puntos(float punto1X, float punto1Y, float punto2X, float punto2Y)
        {
            return (float)Math.Sqrt(Math.Pow(punto2X - punto1X, 2) + Math.Pow(punto2Y - punto1Y, 2));
        }
    }
}