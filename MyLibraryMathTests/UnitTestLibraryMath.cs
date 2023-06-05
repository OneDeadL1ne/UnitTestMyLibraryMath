using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using MyLIbraryMath;

namespace MyLibraryMathTests
{
    [TestClass]
    public class UnitTestAlgebreClass
    {
        #region Test GetRootsTheQuadraticEquation
        [TestMethod]
        public void Test1GetRootsTheQuadraticEquation()
        {
            // Arrange
            double a = 2;
            double b = -5;
            double c = 3;

            double? x1 = 1.5;
            double? x2 = 1;

            // Act
            var test = AlgebraClass.GetRootsTheQuadraticEquation(a, b, c).GetRoots;

            // Assert
            //Assert.AreEqual(res, test);
            Assert.AreEqual(x1, test.x1);
            Assert.AreEqual(x2, test.x2);
        }
        [TestMethod]
        public void Test2GetRootsTheQuadraticEquation()
        {
            // Arrange
            double a = 1;
            double b = -6;
            double c = 9;

            double? x1 = 3;
            double? x2 = 3;

            // Act
            var test = AlgebraClass.GetRootsTheQuadraticEquation(a, b, c).GetRoots;

            // Assert
            Assert.AreEqual(x1, test.x1);
            Assert.AreEqual(x2, test.x2);
        }
        [TestMethod]
        public void Test3GetRootsTheQuadraticEquation()
        {
            // Arrange
            double a = 10;
            double b = -6;
            double c = 9;

            double? x1 = null;
            double? x2 = null;

            // Act
            var test = AlgebraClass.GetRootsTheQuadraticEquation(a, b, c).GetRoots;

            // Assert
            Assert.AreEqual(x1, test.x1);
            Assert.AreEqual(x2, test.x2);
        }
        [TestMethod]
        public void Test4GetRootsTheQuadraticEquation()
        {
            // Arrange
            double a = 1;
            double b = 9;
            double c = 14;
            double? x1 = -2;
            double? x2 = -7;

            // Act
            var test = AlgebraClass.GetRootsTheQuadraticEquation(a, b, c).GetRoots;

            // Assert
            Assert.AreEqual(x1, test.x1);
            Assert.AreEqual(x2, test.x2);

        }
        [TestMethod]
        public void Test5GetRootsTheQuadraticEquation()
        {
            // Arrange
            double a = 1;
            double b = 8;
            double c = 16;
            double? x1 = -4;
            double? x2 = -4;

            // Act
            var test = AlgebraClass.GetRootsTheQuadraticEquation(a, b, c).GetRoots;

            // Assert
            Assert.AreEqual(x1, test.x1);
            Assert.AreEqual(x2, test.x2);

        }
        #endregion

        #region Test GetRootTheLinearEquation
        [TestMethod]
        public void Test1GetRootTheLinearEquation()
        {
            // Arrange
            double a = 8;
            double b = -4;

            double? x = 0.5;


            // Act
            var test = AlgebraClass.GetRootTheLinearEquation(a, b);

            // Assert
            Assert.AreEqual(x, test.GetRoot);
            Console.WriteLine($"{test.GetRoot} = {test.IsEnebleRoot}");
        }

        [TestMethod]
        public void Test2GetRootTheLinearEquation()
        {
            // Arrange
            double a = 11;
            double b = -11;

            double? x = 1;


            // Act
            var test = AlgebraClass.GetRootTheLinearEquation(a, b);

            // Assert
            Assert.AreEqual(x, test.GetRoot);
            Console.WriteLine($"{test.GetRoot} = {test.IsEnebleRoot}");
        }

        [TestMethod]
        public void Test3GetRootTheLinearEquation()
        {
            // Arrange
            double a = 0;
            double b = -9;

            double? x = null;


            // Act
            var test = AlgebraClass.GetRootTheLinearEquation(a, b);

            // Assert
            Assert.AreEqual(x, test.GetRoot);
            Console.WriteLine($"{test.GetRoot} = {test.IsEnebleRoot}");
        }

        [TestMethod]
        public void Test4GetRootTheLinearEquation()
        {
            // Arrange
            double a = 0;
            double b = 0;

            double? x = null;


            // Act
            var test = AlgebraClass.GetRootTheLinearEquation(a, b);

            // Assert
            Assert.AreEqual(x, test.GetRoot);
            Console.WriteLine($"{test.GetRoot} = {test.IsEnebleRoot}");
        }

        [TestMethod]
        public void Test5GetRootTheLinearEquation()
        {
            // Arrange
            double a = 0;
            double b = 1;

            double? x = null;


            // Act
            var test = AlgebraClass.GetRootTheLinearEquation(a, b);

            // Assert
            Assert.AreEqual(x, test.GetRoot);
            Console.WriteLine($"{test.GetRoot} = {test.IsEnebleRoot}");
        }

        #endregion

        #region Test GetRowSum
        [TestMethod]
        public void Test1GetRowSum()
        {
            //Arrange
            double[] array = { 1, 2, 3, 4 };
            double sum = 10;
            //Act

            var test = AlgebraClass.GetRowSum(array);
            //Assert

            Assert.AreEqual(test, sum);
        }

        [TestMethod]
        public void Test2GetRowSum()
        {
            //Arrange
            double[] array = { 1, 2, 3, 10 };
            double sum = 16;
            //Act

            var test = AlgebraClass.GetRowSum(array);
            //Assert

            Assert.AreEqual(test, sum);
        }

        [TestMethod]
        public void Test3GetRowSum()
        {
            //Arrange
            double[] array = { 1, 2, 7, 4 };
            double sum = 14;
            //Act

            var test = AlgebraClass.GetRowSum(array);
            //Assert

            Assert.AreEqual(test, sum);
        }

        [TestMethod]
        public void Test4GetRowSum()
        {
            //Arrange
            double[] array = { 1, 5, 3, 4 };
            double sum = 13;
            //Act

            var test = AlgebraClass.GetRowSum(array);
            //Assert

            Assert.AreEqual(test, sum);
        }

        [TestMethod]
        public void Test5GetRowSum()
        {
            //Arrange
            double[] array = { 9, 2, 3, 4 };
            double sum = 18;
            //Act

            var test = AlgebraClass.GetRowSum(array);
            //Assert

            Assert.AreEqual(test, sum);
        }


        #endregion

        #region Test GetMaxFromRow
        [TestMethod]
        public void Test1GetMaxFromRow()
        {
            //Arrenge
            double[] array = { 1, 2, 3, 4};

            double max = 4;

            //Act

            var test = AlgebraClass.GetMaxFromRow(array);
            //Assert

            Assert.AreEqual(test.GetValue, max);

        }

        [TestMethod]
        public void Test2GetMaxFromRow()
        {
            //Arrenge
            double[] array = { 9, 2, 3, 4 };

            double max = 9;

            //Act

            var test = AlgebraClass.GetMaxFromRow(array);
            //Assert

            Assert.AreEqual(test.GetValue, max);

        }

        [TestMethod]
        public void Test3GetMaxFromRow()
        {
            //Arrenge
            double[] array = { 1, 2, 14, 4 };

            double max = 14;

            //Act

            var test = AlgebraClass.GetMaxFromRow(array);
            //Assert

            Assert.AreEqual(test.GetValue, max);

        }

        [TestMethod]
        public void Test4GetMaxFromRow()
        {
            //Arrenge
            double[] array = { 1, 15, 3, 4 };

            double max = 15;

            //Act

            var test = AlgebraClass.GetMaxFromRow(array);
            //Assert

            Assert.AreEqual(test.GetValue, max);

        }

        [TestMethod]
        public void Test5GetMaxFromRow()
        {
            //Arrenge
            double[] array = {99, 2, 3, 4 };

            double max = 99;

            //Act

            var test = AlgebraClass.GetMaxFromRow(array);
            //Assert

            Assert.AreEqual(test.GetValue, max);

        }


        #endregion

        #region Test GetRowAvg
        [TestMethod]
        public void Test1GetRowAvg()
        {
            //Arrenge
            double[] array = {1,2,3,4};

            double avg = 2.5;
            //Act

            var test = AlgebraClass.GetRowAvg(array);
            //Assert

            Assert.AreEqual(test, avg);
        }

        [TestMethod]
        public void Test2GetRowAvg()
        {
            //Arrenge
            double[] array = { 1, 5, 3};

            double avg = 3;
            //Act

            var test = AlgebraClass.GetRowAvg(array);
            //Assert

            Assert.AreEqual(test, avg);
        }

        [TestMethod]
        public void Test3GetRowAvg()
        {
            //Arrenge
            double[] array = { 1, 2, 3, 4,5 };

            double avg = 3;
            //Act

            var test = AlgebraClass.GetRowAvg(array);
            //Assert

            Assert.AreEqual(test, avg);
        }

        [TestMethod]
        public void Test4GetRowAvg()
        {
            //Arrenge
            double[] array = { 1, 2, 3, 4,8,6 };

            double avg = 4;
            //Act

            var test = AlgebraClass.GetRowAvg(array);
            //Assert

            Assert.AreEqual(test, avg);
        }

        [TestMethod]
        public void Test5GetRowAvg()
        {
            //Arrenge
            double[] array = { 4, 4, 4, 4 };

            double avg = 4;
            //Act

            var test = AlgebraClass.GetRowAvg(array);
            //Assert

            Assert.AreEqual(test, avg);
        }

        #endregion
    }

    [TestClass]
    public class UnitTestGeometryClass
    {
        #region Test GetSquareTriangle
        [TestMethod]
        public void Test1GetSquareTriangle()
        {
            // Arrange
            double a = 10;
            double b = 10;
            double c = 10;

            double S = 43.30;
            // Act
            var test = GeometryClass.GetSquareTriangle(a, b, c);
            // Assert
            Assert.AreEqual(test, S);
        }

        [TestMethod]
        public void Test2GetSquareTriangle()
        {
            // Arrange
            double a = 10;
            double b = 10;
            double c = 9;

            double S = 40.19;
            // Act
            var test = GeometryClass.GetSquareTriangle(a, b, c);
            // Assert
            Assert.AreEqual(test, S);
        }

        [TestMethod]
        public void Test3GetSquareTriangle()
        {
            // Arrange
            double a = 9;
            double b = 6;
            double c = 9;

            double S = 25.46;
            // Act
            var test = GeometryClass.GetSquareTriangle(a, b, c);
            // Assert
            Assert.AreEqual(test, S);
        }

        [TestMethod]
        public void Test4GetSquareTriangle()
        {
            // Arrange
            double a = 10;
            double b = 6;
            double c = 9;

            double S = 26.66;
            // Act
            var test = GeometryClass.GetSquareTriangle(a, b, c);
            // Assert
            Assert.AreEqual(test, S);
        }

        [TestMethod]
        public void Test5GetSquareTriangle()
        {
            // Arrange
            double a = 6;
            double b = 6;
            double c = 9;

            double S = 17.86;
            // Act
            var test = GeometryClass.GetSquareTriangle(a, b, c);
            // Assert
            Assert.AreEqual(test, S);
        }
        #endregion

        #region Test GetSquareRectangularTriangle
        [TestMethod]
        public void Test1GetSquareRectangularTriangle()
        {
            // Arrange
            double a = 3;
            double b = 5;

            double S = 4;
            // Act

            var test = GeometryClass.GetSquareRectangularTriangle(a,b);
            // Assert

            Assert.AreEqual(test, S);
        }

        [TestMethod]
        public void Test2GetSquareRectangularTriangle()
        {
            // Arrange
            double a = 3;
            double b = 9;

            double S = 6;
            // Act

            var test = GeometryClass.GetSquareRectangularTriangle(a, b);
            // Assert

            Assert.AreEqual(test, S);
        }

        [TestMethod]
        public void Test3GetSquareRectangularTriangle()
        {
            // Arrange
            double a = 4;
            double b = 5;

            double S = 4.5;
            // Act

            var test = GeometryClass.GetSquareRectangularTriangle(a, b);
            // Assert

            Assert.AreEqual(test, S);
        }

        [TestMethod]
        public void Test4GetSquareRectangularTriangle()
        {
            // Arrange
            double a = 6;
            double b = 9;

            double S = 7.5;
            // Act

            var test = GeometryClass.GetSquareRectangularTriangle(a, b);
            // Assert

            Assert.AreEqual(test, S);
        }

        [TestMethod]
        public void Test5GetSquareRectangularTriangle()
        {
            // Arrange
            double a = 2;
            double b = 5;

            double S = 3.5;
            // Act

            var test = GeometryClass.GetSquareRectangularTriangle(a, b);
            // Assert

            Assert.AreEqual(test, S);
        }

        #endregion

        #region Test GetSquareRectangle
        [TestMethod]
        public void Test1GetSquareRectangle()
        {
            // Arrange
            double a = 1;
            double b = 1;

            double S = 1;
            // Act

            var test = GeometryClass.GetSquareRectangle(a, b);
            // Assert

            Assert.AreEqual(test, S);
        }

        [TestMethod]
        public void Test2GetSquareRectangle()
        {
            // Arrange
            double a = 5;
            double b = 1;

            double S = 5;
            // Act

            var test = GeometryClass.GetSquareRectangle(a, b);
            // Assert

            Assert.AreEqual(test, S);
        }

        [TestMethod]
        public void Test3GetSquareRectangle()
        {
            // Arrange
            double a = 2;
            double b = 3;

            double S = 6;
            // Act

            var test = GeometryClass.GetSquareRectangle(a, b);
            // Assert

            Assert.AreEqual(test, S);
        }

        [TestMethod]
        public void Test4GetSquareRectangle()
        {
            // Arrange
            double a = 8;
            double b = 7;

            double S = 56;
            // Act

            var test = GeometryClass.GetSquareRectangle(a, b);
            // Assert

            Assert.AreEqual(test, S);
        }

        [TestMethod]
        public void Test5GetSquareRectangle()
        {
            // Arrange
            double a = 8;
            double b = 8;

            double S = 64;
            // Act

            var test = GeometryClass.GetSquareRectangle(a, b);
            // Assert

            Assert.AreEqual(test, S);
        }

        #endregion

        #region Test GetSquareQuadrate
        [TestMethod]
        public void Test1GetSquareQuadrate()
        {
            // Arrange
            double a = 5;

            double S = 25;
            // Act

            var test = GeometryClass.GetSquareQuadrate(a);
            // Assert

            Assert.AreEqual(test, S);
        }

        [TestMethod]
        public void Test2GetSquareQuadrate()
        {
            // Arrange
            double a = 5;

            double S = 25;
            // Act

            var test = GeometryClass.GetSquareQuadrate(a);
            // Assert

            Assert.AreEqual(test, S);
        }

        [TestMethod]
        public void Test3GetSquareQuadrate()
        {
            // Arrange
            double a = 2;

            double S = 4;
            // Act

            var test = GeometryClass.GetSquareQuadrate(a);
            // Assert

            Assert.AreEqual(test, S);
        }

        [TestMethod]
        public void Test4GetSquareQuadrate()
        {
            // Arrange
            double a = 3;

            double S = 9;
            // Act

            var test = GeometryClass.GetSquareQuadrate(a);
            // Assert

            Assert.AreEqual(test, S);
        }

        [TestMethod]
        public void Test5GetSquareQuadrate()
        {
            // Arrange
            double a = 10;

            double S = 100;
            // Act

            var test = GeometryClass.GetSquareQuadrate(a);
            // Assert

            Assert.AreEqual(test, S);
        }

        #endregion

        #region Test GetSquareCircle
        [TestMethod]
        public void Test1GetSquareCircle()
        {
            // Arrange
            double r =1;

            double S = 3.14;
            // Act

            var test = GeometryClass.GetSquareCircle(r);
            // Assert

            Assert.AreEqual(test, S);
        }

        [TestMethod]
        public void Test2GetSquareCircle()
        {
            // Arrange
            double r = 5;

            double S = 78.54;
            // Act

            var test = GeometryClass.GetSquareCircle(r);
            // Assert

            Assert.AreEqual(test, S);
        }

        [TestMethod]
        public void Test3GetSquareCircle()
        {
            // Arrange
            double r = 4;

            double S = 50.27;
            // Act

            var test = GeometryClass.GetSquareCircle(r);
            // Assert

            Assert.AreEqual(test, S);
        }
        [TestMethod]
        public void Test4GetSquareCircle()
        {
            // Arrange
            double r = 3;

            double S = 28.27;
            // Act

            var test = GeometryClass.GetSquareCircle(r);
            // Assert

            Assert.AreEqual(test, S);
        }
        [TestMethod]
        public void Test5GetSquareCircle()
        {
            // Arrange
            double r = 2;

            double S = 12.57;
            // Act

            var test = GeometryClass.GetSquareCircle(r);
            // Assert

            Assert.AreEqual(test, S);
        }

        #endregion

        #region Test GetSquareTrapezoid
        [TestMethod]
        public void Test1GetSquareTrapezoid()
        {
            // Arrange
            double a = 10;
            double b = 10;
            double h = 10;

            double S =100;
            // Act

            var test = GeometryClass.GetSquareTrapezoid(a,b,h);
            // Assert

            Assert.AreEqual(test, S);
        }

        [TestMethod]
        public void Test2GetSquareTrapezoid()
        {
            // Arrange
            double a = 5;
            double b = 10;
            double h = 10;

            double S = 75;
            // Act

            var test = GeometryClass.GetSquareTrapezoid(a, b, h);
            // Assert

            Assert.AreEqual(test, S);
        }

        [TestMethod]
        public void Test3GetSquareTrapezoid()
        {
            // Arrange
            double a = 7;
            double b = 7;
            double h = 10;

            double S = 70;
            // Act

            var test = GeometryClass.GetSquareTrapezoid(a, b, h);
            // Assert

            Assert.AreEqual(test, S);
        }

        [TestMethod]
        public void Test4GetSquareTrapezoid()
        {
            // Arrange
            double a = 7;
            double b = 7;
            double h = 9;

            double S = 63;
            // Act

            var test = GeometryClass.GetSquareTrapezoid(a, b, h);
            // Assert

            Assert.AreEqual(test, S);
        }

        [TestMethod]
        public void Test5GetSquareTrapezoid()
        {
            // Arrange
            double a = 1;
            double b = 7;
            double h = 9;

            double S = 36;
            // Act

            var test = GeometryClass.GetSquareTrapezoid(a, b, h);
            // Assert

            Assert.AreEqual(test, S);
        }
        #endregion
    }

    [TestClass]
    public class UnitTestTrigonometryClass
    {
        #region Test Sin
        [TestMethod]
        public void Test1GetSinAngleangle()
        {
            // Arrange
            int angle = 30;

            double sin = 0.5;
            // Act

            var test = TrigonometryClass.GetSinAngle(angle);
            // Assert
            Assert.AreEqual(test, sin);
        }

        [TestMethod]
        public void Test2GetSinAngleangle()
        {
            int angle = 180;

            double sin = 0;
            // Act

            var test = TrigonometryClass.GetSinAngle(angle);
            // Assert
            Assert.AreEqual(test, sin);
        }
        [TestMethod]
        public void Test3GetSinAngleangle()
        {
            int angle = 90;

            double sin = 1;
            // Act

            var test = TrigonometryClass.GetSinAngle(angle);
            // Assert
            Assert.AreEqual(test, sin);
        }
        [TestMethod]
        public void Test4GetSinAngleangle()
        {
            int angle = 150;

            double sin = 0.5;
            // Act

            var test = TrigonometryClass.GetSinAngle(angle);
            // Assert
            Assert.AreEqual(test, sin);
        }
        [TestMethod]
        public void Test5GetSinAngleangle()
        {
            int angle = 210;

            double sin = -0.5;
            // Act

            var test = TrigonometryClass.GetSinAngle(angle);
            // Assert
            Assert.AreEqual(test, sin);
        }
        #endregion

        #region Test Cos 
        [TestMethod]
        public void Test1GetCosAngleangle()
        {
            // Arrange
            int angle = 240;

            double cos =-0.5;
            // Act
            var test = TrigonometryClass.GetCosAngle(angle);

            // Assert
            Assert.AreEqual(test, cos);

        }
        [TestMethod]
        public void Test2GetCosAngleangle()
        {
            // Arrange
            int angle = 270;

            double cos = 0;
            // Act
            var test = TrigonometryClass.GetCosAngle(angle);

            // Assert
            Assert.AreEqual(test, cos);
        }
        [TestMethod]
        public void Test3GetCosAngleangle()
        {
            // Arrange
            int angle = 300;

            double cos = 0.5;
            // Act
            var test = TrigonometryClass.GetCosAngle(angle);

            // Assert
            Assert.AreEqual(test, cos);
        }
        [TestMethod]
        public void Test4GetCosAngleangle()
        {
            // Arrange
            int angle = 360;

            double cos = 1;
            // Act
            var test = TrigonometryClass.GetCosAngle(angle);

            // Assert
            Assert.AreEqual(test, cos);
        }
        [TestMethod]
        public void Test5GetCosAngleangle()
        {
            // Arrange
            int angle = 180;

            double cos = -1;
            // Act
            var test = TrigonometryClass.GetCosAngle(angle);

            // Assert
            Assert.AreEqual(test, cos);
        }
        #endregion

        #region Test Tg
        [TestMethod]
        public void Test1GetTgAngleangle()
        {
            // Arrange
            int angle = 0;

            double tg = 0;

            // Act

            var test = TrigonometryClass.GetTgAngle(angle);
            // Assert

            Assert.AreEqual(test, tg);
        }
        [TestMethod]
        public void Test2GetTgAngleangle()
        {
            // Arrange
            int angle = 180;

            double tg = 0;

            // Act

            var test = TrigonometryClass.GetTgAngle(angle);
            // Assert

            Assert.AreEqual(test, tg);
        }
        [TestMethod]
        public void Test3GetTgAngleangle()
        {
            // Arrange
            int angle = 210;

            double tg = 0.57;

            // Act

            var test = TrigonometryClass.GetTgAngle(angle);
            // Assert

            Assert.AreEqual(test, tg);
        }
        [TestMethod]
        public void Test4GetTgAngleangle()
        {
            // Arrange
            int angle = 225;

            double tg = 1;

            // Act

            var test = TrigonometryClass.GetTgAngle(angle);
            // Assert

            Assert.AreEqual(test, tg);
        }
        [TestMethod]
        public void Test5GetTgAngleangle()
        {
            // Arrange
            int angle = 315;

            double tg = -1;

            // Act

            var test = TrigonometryClass.GetTgAngle(angle);
            // Assert

            Assert.AreEqual(test, tg);
        }
        #endregion

        #region Test Ctg
        [TestMethod]
        public void Test1GetCtgAngleangle()
        {
            // Arrange
            int angle = 315;

            double ctg = -1;
            // Act

            var test = TrigonometryClass.GetCtgAngle(angle);
            // Assert

            Assert.AreEqual(test, ctg);
        }

        [TestMethod]
        public void Test2GetCtgAngleangle()
        {
            // Arrange
            int angle = 270;

            double ctg = 0;
            // Act

            var test = TrigonometryClass.GetCtgAngle(angle);
            // Assert

            Assert.AreEqual(test, ctg);
        }

        [TestMethod]
        public void Test3GetCtgAngleangle()
        {
            // Arrange
            int angle = 225;

            double ctg = 1;
            // Act

            var test = TrigonometryClass.GetCtgAngle(angle);
            // Assert

            Assert.AreEqual(test, ctg);
        }

        [TestMethod]
        public void Test4GetCtgAngleangle()
        {
            // Arrange
            int angle = 90;

            double ctg = 0;
            // Act

            var test = TrigonometryClass.GetCtgAngle(angle);
            // Assert

            Assert.AreEqual(test, ctg);
        }

        [TestMethod]
        public void Test5GetCtgAngleangle()
        {
            // Arrange
            int angle = 45;

            double ctg = 1;
            // Act

            var test = TrigonometryClass.GetCtgAngle(angle);
            // Assert

            Assert.AreEqual(test, ctg);
        }
        #endregion
    }


}
