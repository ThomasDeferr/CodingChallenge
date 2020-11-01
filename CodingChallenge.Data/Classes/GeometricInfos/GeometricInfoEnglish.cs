using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodingChallenge.Data.Classes.GeometricForms;
using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes.GeometricInfos
{
    public class GeometricInfoEnglish : GeometricInfo
    {
        public GeometricInfoEnglish() {}

        protected override string PrintEmptyList() => "Empty list of shapes!";
        protected override string PrintHeader() => "Shapes report";
        protected override string GetTotalString() => "Total";
        protected override string GetShapesString() => "Shapes";
        protected override string GetAreaString() => "Area";
        protected override string GetPerimeterString() => "Perimeter";

        #region Circle Name
        protected override string GetCircleSingleName() => "Circle";
        protected override string GetCirclePluralName() => "Circles";
        #endregion

        #region Square Name
        protected override string GetSquareSingleName() => "Square";
        protected override string GetSquarePluralName() => "Squares";
        #endregion

        #region EquilateralTriangle Name
        protected override string GetEquilateralTriangleSingleName() => "Triangle";
        protected override string GetEquilateralTrianglePluralName() => "Triangles";
        #endregion

        #region Trapeze Name
        protected override string GetTrapezeSingleName() => "Trapeze";
        protected override string GetTrapezePluralName() => "Trapezes";
        #endregion
    }
}