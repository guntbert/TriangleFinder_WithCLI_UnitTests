/*Client.cs
 * this is the client to modify a circle radius and calculate properties.
 * 
 *  Revision History
 *      Cody Lefebvre, 2016.01.29 : created client
 *      Cody Lefebvre, 2016.02.02 : modified client
 *      Cody Lefebvre, 2016.02.03 : fixed bugs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL_QA__Assignment2;
using NUnit.Framework;

namespace CL_QA_Assignment2.Tests
{

    public class TriangleFinderTests
    {
        //set triangle
        TriangleFinder tf;

        [SetUp]
        //setup by seting ne triangle
        public void setUp()
        {
            tf = new TriangleFinder();
        }
       [Test]
        //test if triangle is equalateral
        public void EqualateralTest()
        {
            Assert.AreEqual("equalateral", tf.Analyze(1, 1, 1));
        }
        [Test]
        //tests if triangle is scalene
        public void ScaleneTest()
        {
            Assert.AreEqual("scalene", tf.Analyze(1, 2, 3));
        }
        [Test]
        //tests if triangle is isoscles
        public void IsoscelesTest()
        {
            Assert.AreEqual("isosceles", tf.Analyze(1, 2, 1));
        }
        [Test]
        //tests if the tame result between 2 different triangles
        public void SameResultTest()
        {
            Assert.AreEqual(new TriangleFinder().Analyze(1,1,1),tf.Analyze(3,3,3));
        }
        [Test]
        //tests if different result with 2 different triangles
        public void DifferentResultTest()
        {
            Assert.AreNotEqual(new TriangleFinder().Analyze(1, 2, 3), tf.Analyze(4, 4, 6));
        }

        [Test]
        //test to see if exception thrown
        public void ZeroExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => tf.Analyze(0,0,0));
        }
        [Test]
        //test to see if exception thrown
        public void negativeExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => tf.Analyze(-1,-1,-1));
        }
        [Test]
        //test to see if exception thrown
        public void DeciamlExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => tf.Analyze( 0.50, 0.20, 0.4));
        }
    }
}
