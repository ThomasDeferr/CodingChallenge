using System;
using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes.GeometricForms
{
    public class Trapeze : IGeometricForm
    {
        private readonly decimal _side;

        public Trapeze(decimal side)
        {
            _side = side;
        }

        public decimal CalculateArea() => _side * _side;

        public decimal CalculatePerimeter() => _side * 4;
    }
}