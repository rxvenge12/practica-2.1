using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Threading.Tasks;

namespace practica_2._1
{
    [TestClass]
    public class GCDTests
    {
        [TestMethod]
        public void FindGCD_TwoNumbers_Positive()
        {
            // Arrange
            GCD gcd = new GCD();

            // Act
            int result = gcd.FindGCD(12, 18);

            // Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void FindGCD_ThreeNumbers_Negative()
        {
            // Arrange
            GCD gcd = new GCD();

            // Act
            int result = gcd.FindGCD(-12, -18, -24);

            // Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void FindGCD_FiveNumbers_ZeroInput()
        {
            // Arrange
            GCD gcd = new GCD();

            // Act
            int result = gcd.FindGCD(0, 18, 0, 36, 0);

            // Assert
            Assert.AreEqual(18, result);
        }
    }

}
