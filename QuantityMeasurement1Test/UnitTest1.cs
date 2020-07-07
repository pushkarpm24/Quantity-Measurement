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
            Feet valueOne = new Feet(0.0);
            Feet valueTwo = new Feet(0.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        [Test]
        public void given0FeetAndNullValue_shouldReturnNotEqual()
        {
            Feet value = new Feet();
            Assert.IsFalse(value.Equals(null));
        }

        [Test]
        public void givenSameFeetRefrence_shouldReturnEqual()
        {
            Feet feetOne = new Feet();
            Feet feetTwo = new Feet();
            Assert.IsFalse(feetOne.Equals(feetTwo));
        }
    }
}