using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLIbraryMath
{
    public static class GeometryClass
    {
        #region GetSquareTriangle
        /// <summary>
        /// Функция для нахождения площади Треугольника
        /// </summary>
        /// <param name="a">Длинна стороны a</param>
        /// <param name="b">Длинна стороны b</param>
        /// <param name="c">Длинна стороны c</param>
        /// <returns>
        /// Площадь Треугольника
        /// </returns>
        public static double GetSquareTriangle(double a, double b, double c)
        {
            double P = (a + b + c) / 2;
            double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            return Math.Round( S, 2);
        }
        #endregion

        #region GetSquareRectangularTriangle
        /// <summary>
        /// Функция для нахождения площади Прямоугольного Треугольника
        /// </summary>
        /// <param name="a">Катет a</param>
        /// <param name="b">Катет b</param>
        /// <returns>
        /// Площадь Прямоугольного Треугольника
        /// </returns>
        public static double GetSquareRectangularTriangle(double a, double b)
        {
            double S = (a + b) / 2;
            return Math.Round(S,2);
        }
        #endregion

        #region GetSquareRectangle
        /// <summary>
        /// Функция для нахождения площади Прямоугольника
        /// </summary>
        /// <param name="a">Длинна Стороны a</param>
        /// <param name="b">Длинна Стороны b</param>
        /// <returns>
        /// Площадь Прямоугольника
        /// </returns>
        public static double GetSquareRectangle(double a, double b)
        {
            return Math.Round(a * b,2);
        }
        #endregion

        #region GetSquareQuadrate
        /// <summary>
        /// Функция для нахождения площади Квадрата
        /// </summary>
        /// <param name="a">Длинна Стороны a</param>
        /// <returns>
        /// Площадь Квадрата
        /// </returns>
        public static double GetSquareQuadrate(double a)
        {
            return Math.Round(a*a, 2);
        }
        #endregion

        #region GetSquareCircle
        /// <summary>
        /// Функция для нахождения площади Круга
        /// </summary>
        /// <param name="a">Длинна Радиуса r</param>
        /// <returns>
        /// Площадь Круга
        /// </returns>
        public static double GetSquareCircle(double r)
        {
            double S = Math.PI * r*r;
            return Math.Round(S, 2);
        }
        #endregion

        #region GetSquareTrapezoid
        /// <summary>
        /// Функция для нахождения площади Трапеции
        /// </summary>
        /// <param name="a">Длинна основания a</param>
        /// <param name="b">Длинна основания b</param>
        /// <param name="h">Длинна высоты h</param>
        /// <returns>
        /// Площадь Трапеции
        /// </returns>
        public static double GetSquareTrapezoid(double a, double b, double h)
        {
            double S = ((a + b) / 2) * h;
            return Math.Round(S, 2);
        }
        #endregion
    }
}
