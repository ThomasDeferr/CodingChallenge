using System;
using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes.GeometricForms
{
    public class Circle : IGeometricForm
    {
        private readonly decimal _diameter;
        
        private decimal Radius { get => _diameter / 2; }

        public Circle(decimal diameter)
        {
            _diameter = diameter;
        }

        public decimal CalculateArea() => (decimal)Math.PI * Radius * Radius;

        public decimal CalculatePerimeter() => (decimal)Math.PI * _diameter;
    }
}