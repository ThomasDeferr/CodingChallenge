using System;
using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes.GeometricForms
{
    public class EquilateralTriangle : IGeometricForm
    {
        private readonly decimal _side;

        public EquilateralTriangle(decimal side)
        {
            _side = side;
        }

        public decimal CalculateArea() => ((decimal)Math.Sqrt(3) / 4) * _side * _side;

        public decimal CalculatePerimeter() => _side * 3;
    }
}