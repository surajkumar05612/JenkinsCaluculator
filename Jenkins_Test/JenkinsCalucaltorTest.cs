using Jenkins_Calculator.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenkins_Test
{
    [TestFixture]
    public class JenkinsCalucaltorTest
    {
        [Test]
        public void TestAdd()
        {
            var controller = new CalculatorController();

            var result = controller.Add(3, 4) as OkObjectResult;

            Assert.IsNotNull(result);
            Assert.AreEqual(7, result.Value);
        }

        [Test]
        public void TestSubtract()
        {
            var controller = new CalculatorController();
            var result = controller.Subtract(7, 4) as OkObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Value);
        }

        [Test]
        public void TestMultiply()
        {
            var controller = new CalculatorController();
            var result = controller.Multiply(7, 4) as OkObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(28, result.Value);
        }

        [Test]
        public void TestDivide()
        {
            var controller = new CalculatorController();
            var result = controller.Divide(8, 4) as OkObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Value);
        }

        [Test]
        public void TestDivideByZero()
        {
            var controller = new CalculatorController();
            var result = controller.Divide(7, 0) as OkObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual("Cannot divide by zero", result.Value);
        }
    }
}
