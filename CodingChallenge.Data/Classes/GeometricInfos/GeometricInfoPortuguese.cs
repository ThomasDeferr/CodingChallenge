using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodingChallenge.Data.Classes.GeometricForms;
using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes.GeometricInfos
{
    public class GeometricInfoPortuguese : GeometricInfoLanguage
    {
        public GeometricInfoPortuguese() {}

        protected override string PrintEmptyList() => "Lista vazia de formas!";
        protected override string PrintHeader() => "Relatório de Formulários";
        protected override string GetTotalString() => "Total";
        protected override string GetShapesString() => "Formas";
        protected override string GetAreaString() => "Área";
        protected override string GetPerimeterString() => "Perímetro";

        #region Circle Name
        protected override string GetCircleSingleName() => "Círculo";
        protected override string GetCirclePluralName() => "Círculos";
        #endregion

        #region Square Name
        protected override string GetSquareSingleName() => "Quadrado";
        protected override string GetSquarePluralName() => "Quadrados";
        #endregion

        #region EquilateralTriangle Name
        protected override string GetEquilateralTriangleSingleName() => "Triângulo";
        protected override string GetEquilateralTrianglePluralName() => "Triângulos";
        #endregion

        #region Trapeze Name
        protected override string GetTrapezeSingleName() => "Trapézio";
        protected override string GetTrapezePluralName() => "Trapézios";
        #endregion
    }
}