using NUnit.Framework;
using QuantityMeasurement1;

namespace QuantityMeasurement1Test
{
    public class Tests
    {
       
         bool result;
                 
        [SetUp]
        public void Setup()
        {
            result = false;
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

        [Test]
        public void givenImproper_InchesTypeObject_Should_Return_False()
        {
            Inches valueOne = new Inches();
            object valueTwo = new object();
            Assert.IsFalse(valueOne.Equals(valueTwo));
        }

        [Test]
        public void  given_OneFeetAndTwelveInch_ShouldReturnTrue()
        {
            if ( Quantities.IncheConversion(12.0, "inches") == Quantities.IncheConversion(1.0, "feet"))
            {
                result = true;
            }

            Assert.IsTrue(result);
        }

        [Test]
        public void given_ZeroFeetAndZeroInch_ShouldReturnTrue()
        {
            if (Quantities.IncheConversion(0.0, "feet") == Quantities.IncheConversion(0.0, "inches"))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void given_OneFeetAndOneInch_ShouldReturnFalse()
        {
            if (Quantities.IncheConversion(1.0, "feet") == Quantities.IncheConversion(1.0, "inches"))
            {
                result = true;
            }
            Assert.IsFalse(result);
        }

        [Test]
        public void given_OneFeetAndOneYard_ShouldReturn_False()
        {
            if (Quantities.IncheConversion(1.0, "feet") == Quantities.IncheConversion(1.0, "yards"))
            {
                result = true;
            }
            Assert.IsFalse(result);

        }

        [Test]
        public void given_ThreeFeetAndOneYard_ShouldReturn_True()
        {
            if (Quantities.IncheConversion(3.0, "feet") == Quantities.IncheConversion(1.0, "yards"))
            {
                result = true;
            }
            Assert.IsTrue(result);

        }

        [Test]
        public void Given_OneIncheAndOneYard_ShouldReturn_False()
        {
            if (Quantities.IncheConversion(1.0, "inches") == Quantities.IncheConversion(1.0, "yards"))
            {
                result = true;
            }            
            Assert.IsFalse(result);
        }

        [Test]
        public void Given_ThirtySixIncheAndOneYard_ShouldReturn_True()
        {
            if (Quantities.IncheConversion(36.0, "inches") == Quantities.IncheConversion(1.0, "yards"))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void Given_TwoInchAndFiveCM_Should_Return_True()
        {
            if (Quantities.IncheConversion(2, "inches") == Quantities.IncheConversion(5, "cm"))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void Given_TwoInchAndTwoInch_AfterAdditon_ShouldReturn_FourInch()
        {
            result = Quantities.Addition(Quantities.IncheConversion(2, "inches"), Quantities.IncheConversion(2, "inches"), Quantities.IncheConversion(4, "inches"));
            Assert.IsTrue(result);
        }

        [Test]
        public void Given_OneFeetAndTwoInch_AfterAdditon_ShouldReturn_FourteenInch()
        {
            result = Quantities.Addition(Quantities.IncheConversion(1, "feet"), Quantities.IncheConversion(2, "inches"), Quantities.IncheConversion(14, "inches"));
            Assert.IsTrue(result);
        }

        [Test]
        public void Given_OneFeetAndOneFeet_AfterAdditon_ShouldReturn_TwentyFourInch()
        {
            result = Quantities.Addition(Quantities.IncheConversion(1, "feet"), Quantities.IncheConversion(1, "feet"), Quantities.IncheConversion(24, "inches"));
            Assert.IsTrue(result);
        }

        [Test]
        public void Given_TwoInchAndTwoPointFiveCM_AfterAdditon_ShouldReturn_ThreeInch()
        {
            result = Quantities.Addition(Quantities.IncheConversion(2, "inches"), Quantities.IncheConversion(2.5, "cm"), Quantities.IncheConversion(3, "inches"));
            Assert.IsTrue(result);
        }

        [Test]
        public void Given_OneGallonAndThreePointSevenEightLiter_AfterCompare_ShuouldReturnTrue()
        {
            if (Quantities.LiterConversion(1, "gallon") == Quantities.LiterConversion(3.785, "liter"))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }

        [Test]
        public void Given_OneLiterAndThousandMl_AfterCompare_ShuouldReturnTrue()
        {
            if (Quantities.LiterConversion(1, "litre") == Quantities.LiterConversion(1000, "ml"))
            {
                result = true;
            }
            Assert.IsTrue(result);
        }



    }
}