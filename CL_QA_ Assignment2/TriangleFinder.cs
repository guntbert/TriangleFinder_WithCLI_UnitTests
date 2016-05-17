/*TriangleFinder.cs
 * this is the class to analyze a triangles sides
 * 
 *  Revision History
 *      Cody Lefebvre, 2016.02.04 : created Analyze Method
 *      Cody Lefebvre, 2016.02.06 : added exceptions
 *      Cody Lefebvre, 2016.02.10 : fixed bugs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_QA__Assignment2
{
    public class TriangleFinder
    {
        //constructor sets 1,1,1 equalateral triangle
        public TriangleFinder()
        {
            
        }

        //analyzes triangles sides to determin type of triangle
        public string Analyze(double sideA, double sideB, double sideC)
        {
            //throw exception if = 0
            if(sideA ==0 && sideB ==0 && sideC ==0)
            {
                throw new System.ArgumentException("parameter cant be 0");
            }
            //throw exception if below zero
            if(sideA < 0 && sideB < 0 && sideC < 0)
            {
                throw new System.ArgumentException("parameter cant be below 0");
            }
            //throw exception if decimal below 1
            if (sideA < 1 && sideB < 1 && sideC < 1)
            {
                throw new System.ArgumentException("parameter cant be decimal below 1");
            }
            //returns scalene if all side not =
            if (sideA != sideB && sideA != sideC && sideB != sideC)
            {
                return "scalene";
            }
            //returns equalateral if sides are =
            if(sideA == sideB && sideA == sideC && sideB == sideC)
            {
                return "equalateral";
            }
            //else return isosceles
            else
            {
                return "isosceles";
            }
        }
    }
}
