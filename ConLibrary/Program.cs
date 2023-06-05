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





            //Console.WriteLine(AlgebraClass.GetRootsTheQuadraticEquation(2,-5,3).x1);
            //Console.WriteLine(AlgebraClass.GetRootsTheQuadraticEquation(2,-5,3).x2);
            Console.WriteLine(AlgebraClass.GetRootsTheQuadraticEquation(2,-5,3).GetRoots.x1);
            //Console.WriteLine(AlgebraClass.GetRootsTheQuadraticEquation(1,-6,9).CountRoots);

            //Console.WriteLine(AlgebraClass.GetRootTheLinearEquation(0,0).x);



            Console.ReadKey();
            
        }
    }
}
