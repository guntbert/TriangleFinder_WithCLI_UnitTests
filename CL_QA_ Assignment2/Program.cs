/*program.cs
 * this is the client to analyse a triangle of the details given by user
 * 
 *  Revision History
 *      Cody Lefebvre, 2016.02.4 : created client
 *      Cody Lefebvre, 2016.02.08 : modified client
 *      Cody Lefebvre, 2016.02.10 : fixed bugs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL_QA__Assignment2;

namespace CL_QA__Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //set triangle and menu choice
            TriangleFinder tf = new TriangleFinder();
            int menuchoice = 0;
            Console.WriteLine("Welcome What would you like to do?");

            while (menuchoice != 3)
            {
                //display menu
                Console.WriteLine("Please select a menu option:");
                Console.WriteLine("1.) Enter triangle dimensions");
                Console.WriteLine("2.) Exit");
                menuchoice = Convert.ToInt16(Console.ReadLine());

                //details for each menu choice
                switch (menuchoice)
                {
                    //determine type of triangle
                    case 1:
                        Console.WriteLine("Enter the 3 sides of the rectangle");
                        Console.WriteLine("Side A:");
                        float sideA = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Side B:");
                        float sideB = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Side C:");
                        float sideC = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine(tf.Analyze(sideA, sideB, sideC));
                        break;

                    //exit console
                    case 2:
                        Environment.Exit(0);
                        break;

                    //default response if no option selected
                    default:
                        Console.WriteLine("Invalid Selection");
                        break;
                }
            }
        }
    }
}
