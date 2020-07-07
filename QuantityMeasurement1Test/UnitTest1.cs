using NUnit.Framework;
using QuantityMeasurement1;

namespace QuantityMeasurement1Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void givenZeroFeetAndZeroFeet_shouldReturnEqual()
        {
            Feet value_1 = new Feet(0.0);
            Feet value_2 = new Feet(0.0);
            Assert.AreEqual(value_1, value_2);
        }
    }
}