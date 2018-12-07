using NUnit.Framework;
using System.Collections.Generic;
using Web.Services;

namespace Web.Tests
{
    [TestFixture]
    public class FibonacciServiceTests
    {
        [Test]
        public void ItShouldReturnFibonacciList()
        {
            List<int> actualList = new FibonacciService().GenerateFibonacciSequence(10) as List<int>;
            Assert.That(actualList[5], Is.EqualTo(5));
        }
    }
}