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
            Feet feetOne = new Feet(0.0);
            Feet feetTwo = new Feet(0.0);
            Assert.IsTrue(feetOne.feet.Equals(feetTwo.feet));
        }

        [Test]
        public void givenZeroFeetAndNullValue_shouldReturnNotEqual()
        {
            Feet value = new Feet();
            Assert.IsFalse(value.Equals(null));
        }

        [Test]
        public void givenSameFeetRefrence_shouldReturnFalse()
        {
            Feet feetOne = new Feet();
            Feet feetTwo = new Feet();
            Assert.IsFalse(feetOne.Equals(feetTwo));
        }

        [Test]
        public void givenImproper_TypeObject_ShouldReturn_False()
        {
            Feet valueOne = new Feet();
            object valueTwo = new object();
            Assert.IsFalse(valueOne.Equals(valueTwo));
        }

        [Test]
        public void givenEqualValue_ShuoldReturn_True()
        {
            Feet feetOne = new Feet();
            feetOne.feet = 4.6;
            Assert.IsTrue(feetOne.Equals(feetOne));
        }

        [Test]
        public void givenZeroInchAndZeroInch_shouldReturnEqual()
        {
            Inches inchOne = new Inches(0.0);
            Inches inchTwo = new Inches(0.0);
            Assert.IsTrue(inchOne.inches.Equals(inchTwo.inches));
        }

        [Test]
        public void givenZeroInchAndNull_shouldReturnNotEqual()
        {
            Inches inchOne = new Inches();
            Assert.IsFalse(inchOne.Equals(null));
        }

        [Test]
        public void givenSameInchRefrence_shouldReturnFalse()
        {
            Inches inchOne = new Inches();
            Inches inchTwo = new Inches();
            Assert.IsFalse(inchOne.Equals(inchTwo));
        }

        [Test]
        public void givenSameInch_Value_ShuoldReturn_True()
        {
            Inches inchOne = new Inches();
            inchOne.inches = 4.6;
            Assert.IsTrue(inchOne.Equals(inchOne));
        }
    }
}