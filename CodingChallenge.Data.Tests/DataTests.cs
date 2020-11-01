using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.GeometricInfos;
using CodingChallenge.Data.Interfaces;
using CodingChallenge.Data.Classes.GeometricForms;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [Test]
        public void SpanishPrint_EmptyList_EmptyMessage()
        {
            GeometricInfoSpanish info = new GeometricInfoSpanish();
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>", info.Print(new List<IGeometricForm>()));
        }

        [Test]
        public void EnglishPrint_EmptyList_EmptyMessage()
        {
            GeometricInfoEnglish info = new GeometricInfoEnglish();
            Assert.AreEqual("<h1>Empty list of shapes!</h1>", info.Print(new List<IGeometricForm>()));
        }

        [Test]
        public void PortuguesePrint_EmptyList_EmptyMessage()
        {
            GeometricInfoPortuguese info = new GeometricInfoPortuguese();
            Assert.AreEqual("<h1>Lista vazia de formas!</h1>", info.Print(new List<IGeometricForm>()));
        }

        [Test]
        public void SpanishPrint_OneSquare_CalculatedMessage()
        {
            GeometricInfoSpanish info = new GeometricInfoSpanish();
            var geometricForms = new List<IGeometricForm> {new Square(side: 5)};
            var resumen = info.Print(geometricForms);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perímetro 20<br/>TOTAL:<br/>1 Formas Perímetro 20 Area 25", resumen);
        }

        [Test]
        public void EnglishPrint_MultiplesSquare_CalculatedMessage()
        {
            GeometricInfoEnglish info = new GeometricInfoEnglish();
            var geometricForms = new List<IGeometricForm> 
            {
                new Square(side: 5),
                new Square(side: 1),
                new Square(side: 3)
            };
            var resumen = info.Print(geometricForms);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36<br/>TOTAL:<br/>3 Shapes Perimeter 36 Area 35", resumen);
        }

        [Test]
        public void PortuguesePrint_MultiplesSquare_CalculatedMessage()
        {
            GeometricInfoPortuguese info = new GeometricInfoPortuguese();
            var geometricForms = new List<IGeometricForm> 
            {
                new Square(side: 5),
                new Square(side: 1),
                new Square(side: 3)
            };
            var resumen = info.Print(geometricForms);

            Assert.AreEqual("<h1>Relatório de Formulários</h1>3 Quadrados | Área 35 | Perímetro 36<br/>TOTAL:<br/>3 Formas Perímetro 36 Área 35", resumen);
        }

        [Test]
        public void EnglishPrint_MultiplesForms_CalculatedMessage()
        {
            GeometricInfoEnglish info = new GeometricInfoEnglish();
            var geometricForms = new List<IGeometricForm> 
            {
                new Square(side: 5),
                new Circle(diameter: 3),
                new EquilateralTriangle(side: 4),
                new Square(side: 2),
                new EquilateralTriangle(side: 9),
                new Circle(diameter: 2.75m),
                new EquilateralTriangle(side: 4.2m)
            };
            var resumen = info.Print(geometricForms);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28<br/>2 Circles | Area 13,01 | Perimeter 18,06<br/>3 Triangles | Area 49,64 | Perimeter 51,6<br/>TOTAL:<br/>7 Shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [Test]
        public void SpanishPrint_MultiplesForms_CalculatedMessage()
        {
            GeometricInfoSpanish info = new GeometricInfoSpanish();
            var geometricForms = new List<IGeometricForm> 
            {
                new Square(side: 5),
                new Circle(diameter: 3),
                new EquilateralTriangle(side: 4),
                new Square(side: 2),
                new EquilateralTriangle(side: 9),
                new Circle(diameter: 2.75m),
                new EquilateralTriangle(side: 4.2m)
            };
            var resumen = info.Print(geometricForms);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perímetro 28<br/>2 Círculos | Area 13,01 | Perímetro 18,06<br/>3 Triángulos | Area 49,64 | Perímetro 51,6<br/>TOTAL:<br/>7 Formas Perímetro 97,66 Area 91,65",
                resumen);
        }

        [Test]
        public void PortuguesePrint_MultiplesForms_CalculatedMessage()
        {
            GeometricInfoPortuguese info = new GeometricInfoPortuguese();
            var geometricForms = new List<IGeometricForm> 
            {
                new Square(side: 5),
                new Circle(diameter: 3),
                new EquilateralTriangle(side: 4),
                new Square(side: 2),
                new EquilateralTriangle(side: 9),
                new Circle(diameter: 2.75m),
                new EquilateralTriangle(side: 4.2m)
            };
            var resumen = info.Print(geometricForms);

            Assert.AreEqual(
                "<h1>Relatório de Formulários</h1>2 Quadrados | Área 29 | Perímetro 28<br/>2 Círculos | Área 13,01 | Perímetro 18,06<br/>3 Triângulos | Área 49,64 | Perímetro 51,6<br/>TOTAL:<br/>7 Formas Perímetro 97,66 Área 91,65",
                resumen);
        }
    }
}