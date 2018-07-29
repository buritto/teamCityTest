using ClassLibrary1;
using FluentAssertions;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestsIntOperations
    {
        [Test]
        public void Should_add_two_integer_number()
        {
            var operations = new IntOperations();
            var firstNumber = 2;
            var secondNumber = 3;

            var expected = firstNumber + secondNumber;

            operations.Add(firstNumber, secondNumber).Should().Be(expected);
        }

        [Test]
        public void Should_product_two_integer()
        {
            var operations = new IntOperations();
            var firstNumber = 3;
            var secondNumber = 2;

            var expected = firstNumber * secondNumber;
            operations.Product(firstNumber, secondNumber).Should().Be(expected);
        }
        
    }
}