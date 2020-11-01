using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodingChallenge.Data.Classes.GeometricForms;

namespace CodingChallenge.Data.Interfaces
{
    public abstract class GeometricInfo
    {
        public string Print(List<IGeometricForm> forms)
        {
            var sb = new StringBuilder();

            if (!forms.Any())
            {
                sb.Append($"<h1>{PrintEmptyList()}</h1>");
            }
            else
            {
                sb.Append($"<h1>{PrintHeader()}</h1>");
                sb.Append(PrintBody(forms));
                sb.Append(PrintFooter(forms));
            }
            
            return sb.ToString();
        }

        protected abstract string PrintEmptyList();
        protected abstract string PrintHeader();
        protected string PrintBody(List<IGeometricForm> forms)
        {
            var sb = new StringBuilder();

            var formsByType = forms.GroupBy(f => f.GetType());
            foreach(var formsType in formsByType) 
            {
                decimal sumAreaByType = formsType.Sum(f => f.CalculateArea());
                decimal sumPerimeterByType = formsType.Sum(f => f.CalculatePerimeter());

                sb.Append(GetLine(formsType.Key, formsType.Count(), sumAreaByType, sumPerimeterByType));
                sb.Append("<br/>");
            }
            
            return sb.ToString();
        }
        protected string PrintFooter(List<IGeometricForm> forms) 
        {
            var sb = new StringBuilder();
            decimal sumPerimeter = forms.Sum(f => f.CalculatePerimeter());
            decimal sumArea = forms.Sum(f => f.CalculateArea());

            sb.Append($"{GetTotalString().ToUpper()}:<br/>");
            sb.Append($"{forms.Count()} {GetShapesString()} ");
            sb.Append($"{GetPerimeterString()} {sumPerimeter.ToString("#.##")} ");
            sb.Append($"{GetAreaString()} {sumArea.ToString("#.##")}");
            
            return sb.ToString();
        }

        protected string GetLine(Type formType, int quantity, decimal area, decimal perimeter)
        {
            return $"{quantity} {GetFormName(formType, quantity)} | {GetAreaString()} {area:#.##} | {GetPerimeterString()} {perimeter:#.##}";
        }

        protected string GetFormName(Type formType, int quantity)
        {
            string name = "";

            switch (formType.Name)
            {
                case nameof(Circle): name = quantity > 1 ? GetCirclePluralName() : GetCircleSingleName();
                    break;
                case nameof(Square): name = quantity > 1 ? GetSquarePluralName() : GetSquareSingleName();
                    break;
                case nameof(EquilateralTriangle): name = quantity > 1 ? GetEquilateralTrianglePluralName() : GetEquilateralTriangleSingleName();
                    break;
                case nameof(Trapeze): name = quantity > 1 ? GetTrapezePluralName() : GetTrapezeSingleName();
                    break;
                default: 
                    throw new Exception("The geometric form don't exist.");
            }

            return name;
        }

        protected abstract string GetTotalString();
        protected abstract string GetShapesString();
        protected abstract string GetAreaString();
        protected abstract string GetPerimeterString();

        #region Circle Name
        protected abstract string GetCircleSingleName();
        protected abstract string GetCirclePluralName();
        #endregion

        #region Square Name
        protected abstract string GetSquareSingleName();
        protected abstract string GetSquarePluralName();
        #endregion

        #region EquilateralTriangle Name
        protected abstract string GetEquilateralTriangleSingleName();
        protected abstract string GetEquilateralTrianglePluralName();
        #endregion

        #region Trapeze Name
        protected abstract string GetTrapezeSingleName();
        protected abstract string GetTrapezePluralName();
        #endregion
    }
}