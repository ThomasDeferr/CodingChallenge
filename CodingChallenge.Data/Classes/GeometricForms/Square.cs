using System;
using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes.GeometricForms
{
    public class Square : IGeometricForm
    {
        private readonly decimal _side;

        public Square(decimal side)
        {
            _side = side;
        }

        public decimal CalculateArea() => _side * _side;

        public decimal CalculatePerimeter() => _side * 4;
    }
}