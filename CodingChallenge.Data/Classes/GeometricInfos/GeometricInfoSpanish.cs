using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodingChallenge.Data.Classes.GeometricForms;
using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes.GeometricInfos
{
    public class GeometricInfoSpanish : GeometricInfo
    {
        public GeometricInfoSpanish() {}

        protected override string PrintEmptyList() => "Lista vacía de formas!";
        protected override string PrintHeader() => "Reporte de Formas";
        protected override string GetTotalString() => "Total";
        protected override string GetShapesString() => "Formas";
        protected override string GetAreaString() => "Area";
        protected override string GetPerimeterString() => "Perímetro";

        #region Circle Name
        protected override string GetCircleSingleName() => "Círculo";
        protected override string GetCirclePluralName() => "Círculos";
        #endregion

        #region Square Name
        protected override string GetSquareSingleName() => "Cuadrado";
        protected override string GetSquarePluralName() => "Cuadrados";
        #endregion

        #region EquilateralTriangle Name
        protected override string GetEquilateralTriangleSingleName() => "Triángulo";
        protected override string GetEquilateralTrianglePluralName() => "Triángulos";
        #endregion

        #region Trapeze Name
        protected override string GetTrapezeSingleName() => "Trapecio";
        protected override string GetTrapezePluralName() => "Trapecios";
        #endregion
    }
}