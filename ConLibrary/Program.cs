using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLIbraryMath;

namespace ConLibrary
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Алгебра
            Console.WriteLine($"Корни квадратного ур-я  {AlgebraClass.GetRootsTheQuadraticEquation(2, -5, 3).GetRoots}\n");

            Console.WriteLine($"Корень линейного ур-я {AlgebraClass.GetRootTheLinearEquation(8, -4).GetRoot}\n");

            double[] array = { 5, 6, 2, 90, 1 };
            Console.Write($"Последовательность ");
            foreach( var item in array )
            {
                Console.Write($"{item}");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Сумма последовательность {AlgebraClass.GetRowSum(array)}\n");

            Console.WriteLine($"Максимальное значение последовательности {AlgebraClass.GetMaxFromRow(array).GetValue} \n");

            Console.WriteLine($"Среднее значение последовательности {AlgebraClass.GetRowAvg(array)} \n");

            //Геометрия
            Console.WriteLine($"Площадь треугольника {GeometryClass.GetSquareTriangle(10, 10, 10)} \n");

            Console.WriteLine($"Площадь прямоугольного треугольника {GeometryClass.GetSquareRectangularTriangle(3, 5)} \n");

            Console.WriteLine($"Площадь Прямоугольника {GeometryClass.GetSquareRectangle(5,4)} \n");

            Console.WriteLine($"Площадь Квадрата {GeometryClass.GetSquareQuadrate(5)} \n");

            Console.WriteLine($"Площадь Круга {GeometryClass.GetSquareCircle(2)} \n");

            Console.WriteLine($"Площадь трапеции {GeometryClass.GetSquareTrapezoid(2,5,3)} \n");

            //Тригонометрия
            int angle = 60;
            Console.WriteLine($"Синус 60 = {TrigonometryClass.GetSinAngle(angle)} \n");

            Console.WriteLine($"Косинус 60 = {TrigonometryClass.GetCosAngle(angle)} \n");

            Console.WriteLine($"Тангенс 60 = {TrigonometryClass.GetTgAngle(angle)} \n");

            Console.WriteLine($"Котангенс 60 = {TrigonometryClass.GetCtgAngle(angle)} \n");

            Console.ReadKey();
            
        }
    }
}
