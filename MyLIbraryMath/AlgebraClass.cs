using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLIbraryMath
{
    public static class AlgebraClass
    {
        #region GetRootsTheQuadraticEquation
        /// <summary>
        /// Функция для нахождения корней квадратного уравнения ax²+bx+c=0
        /// </summary>
        /// <param name="a">коэффициент при x²</param>
        /// <param name="b">коэффициент при b</param>
        /// <param name="c">число с</param>
        /// <returns>
        /// Корни квадратного уравнения
        /// </returns>
        public static ((double? x1, double? x2) GetRoots, int CountRoots) GetRootsTheQuadraticEquation(double a, double b, double c)
        {
            
            double? x1=null;
            double? x2 =null;
            
            double D = (b * b) - 4 * a * c;
            
            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                return ((x1, x2),2);
            }

            if (D == 0)
            {
                x1 = (-b) / (2 * a);
                x2 = x1;
                return ((x1, x2),1);
                    
            }
            
            return ((x1, x2), 0);
        }
        #endregion

        #region GetRootTheLinearEquation
        /// <summary>
        /// Функция для нахождения корней линейного уравнения ax+b=0
        /// </summary>
        /// <param name="a">коэффициент при x</param>
        /// <param name="b">коэффициент при b</param>
        /// <returns>
        /// Корни линейного уравнения
        /// </returns>
        public static (double? GetRoot, string IsEnebleRoot)GetRootTheLinearEquation(double a, double b)
        {
            double? x = null;
            if (a !=0)
            {
                x = -b / a;
                return (x, "Корень");
            }

            if (a==0 && b!=0)
            {
                return (x, "Корней не существует");
            }

            return (x,"Корнем является любое число");
        }
        #endregion

        #region GetRowSum
        /// <summary>
        /// Функция для нахождения суммы ряда
        /// </summary>
        /// <param name="array">Массив ряда</param>
        /// <returns>
        /// Сумма элементов ряда
        /// </returns>
        public static double GetRowSum(double[] array)
        {
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }


        #endregion

        #region GetMaxFromRow
        /// <summary>
        /// Функция для нахождения максимального елемента в ряду
        /// </summary>
        /// <param name="array">Массив ряда</param>
        /// <returns>
        /// Максимальное число ряда
        /// </returns>
        public static (double GetValue, int Index) GetMaxFromRow(double[] array)
        {
            double max = array[0];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    index = i;
                }
            }

            return (max, index);
        }
        #endregion

        #region GetRowAvg
        /// <summary>
        /// Функция для нахождения среднего значения ряда
        /// </summary>
        /// <param name="array">Массив ряда</param>
        /// <returns>
        /// Среднее значения ряда
        /// </returns>
        public static double GetRowAvg(double[] array)
        {
            return Math.Round(GetRowSum(array) / array.Length, 2);
        }
        #endregion
    }
}
