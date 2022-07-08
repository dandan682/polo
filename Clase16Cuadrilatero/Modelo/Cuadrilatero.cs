using System;
namespace Clase16Cuadrilatero.Modelo
{
    public abstract class Cuadrilatero
    {
        private int _vertice1X;
        private int _vertice1Y;
        private int _vertice2X;
        private int _vertice2Y;
        private int _vertice3X;
        private int _vertice3Y;
        private int _vertice4X;
        private int _vertice4Y;


        public int Vertice1X { get => _vertice1X; set => _vertice1X = value; }
        public int Vertice1Y { get => _vertice1Y; set => _vertice1Y = value; }
        public int Vertice2X { get => _vertice2X; set => _vertice2X = value; }
        public int Vertice2Y { get => _vertice2Y; set => _vertice2Y = value; }
        public int Vertice3X { get => _vertice3X; set => _vertice3X = value; }
        public int Vertice3Y { get => _vertice3Y; set => _vertice3Y = value; }
        public int Vertice4X { get => _vertice4X; set => _vertice4X = value; }
        public int Vertice4Y { get => _vertice4Y; set => _vertice4Y = value; }

        public Cuadrilatero(int vertice1X, int vertice1Y, int vertice2X, int vertice2Y,
            int vertice3X, int vertice3Y, int vertice4X, int vertice4Y)
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
    }
}