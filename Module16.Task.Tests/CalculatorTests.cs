using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16.Task.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Additional(20, 10), Is.EqualTo(30));
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Subtraction(20, 10), Is.EqualTo(10));
        }

        [Test]
        public void MiltiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Miltiplication(20, 10), Is.EqualTo(200));
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(20, 10), Is.EqualTo(2));
        }

    }

}