using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLIbraryMath
{
    public static class TrigonometryClass
    {
        #region GetSinAngle
        /// <summary>
        /// Функция для нахождения Синуса угла
        /// </summary>
        /// <param name="angle"> Угол</param>
        /// <returns>
        /// Синус угла
        /// </returns>
        public static double GetSinAngle(int angle)
        {
            
            double radians = Math.PI * angle/180;
            double sin = Math.Round(Math.Sin(radians), 2);
            return sin;
        }
        #endregion

        #region GetCosAngle
        /// <summary>
        /// Функция для нахождения Косинуса угла
        /// </summary>
        /// <param name="angle"> Угол</param>
        /// <returns>
        /// Косинуса угла
        /// </returns>
        public static double GetCosAngle(int angle)
        {
            double radians = Math.PI * angle / 180;
            double cos = Math.Round(Math.Cos(radians), 2);
            return cos;
        }
        #endregion

        #region GetTgAngle
        /// <summary>
        /// Функция для нахождения Тангенса угла
        /// </summary>
        /// <param name="angle"> Угол</param>
        /// <returns>
        /// Тангенса угла
        /// </returns>
        public static double GetTgAngle(int angle)
        {
            
            double sin = GetSinAngle(angle);
            double cos = GetCosAngle(angle);

            double tg = Math.Round((sin/cos),2);
            return tg;
        }
        #endregion

        #region GetCtgAngle
        /// <summary>
        /// Функция для нахождения Котангенса угла
        /// </summary>
        /// <param name="angle"> Угол</param>
        /// <returns>
        /// Котангенса угла
        /// </returns>
        public static double GetCtgAngle(int angle)
        {

            double sin = GetSinAngle(angle);
            double cos = GetCosAngle(angle);

            double ctg = Math.Round((cos/ sin), 2);
            return ctg;
        }
        #endregion


    }
}
