using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW212_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {

        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Use the DataRow values to test the Add method
            double result = num1 + num2;
            Assert.AreEqual(result, SimpleMath.Add(num1, num2));
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            // Use a few pairs of values to test the Multiply method
            double result = num1 * num2;
            Assert.AreEqual(result, SimpleMath.Multiply(num1, num2));
        }

        [TestMethod]
        [DataRow(10, 0)]
        public void Divide_DenominatorZero_ThrowsArgumentException(double num1, double num2)
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"
            Assert.ThrowsException<ArgumentException>(() => SimpleMath.Divide(num1, num2));
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        public void Divide_TwoValidNumbers_ReturnsProduct(double num1, double num2)
        {
            double result = num1 / num2;

            Assert.AreEqual(result, SimpleMath.Divide(num1, num2));
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(-1, -10)]
        public void Subtract_TwoValidNumbers_ReturnsProduct(double num1, double num2)
        {
            double result = num1 - num2;

            Assert.AreEqual(result, SimpleMath.Subtract(num1, num2));
        }
    }
}