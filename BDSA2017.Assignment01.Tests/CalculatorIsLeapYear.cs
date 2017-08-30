using Xunit;

namespace BDSA2017.Exercise01.Tests
{
    public partial class CalculatorTests
    {
      
        [Theory]
        [InlineData(-12)]
        [InlineData(0)]
        [InlineData(1581)]
        public void LeapYearAfter1582(int year)
        {
            Assert.Throws<System.ArgumentException>(() => Calculator.IsLeapYear(year));
           
        }

        [Theory]
        [InlineData(10000)]
        [InlineData(1000000)]
        public void yearsAfter9999NotSupported(int year)
        {
            Assert.Throws<System.ArgumentException>(() => Calculator.IsLeapYear(year));
        }

        [Theory]
        [InlineData(1604)]
        [InlineData(1608)]
        [InlineData(1616)]
        [InlineData(1620)]
        public void LeapYearIsDivisibleBy4(int year)
        {
            Assert.True(Calculator.IsLeapYear(year));
        }

        [Theory]
        [InlineData(1685)]
        [InlineData(1633)]
        [InlineData(5831)]
        [InlineData(6521)]
        [InlineData(6237)]
        public void IsComonYear(int year)
        {
            Assert.False(Calculator.IsLeapYear(year));
        }


        [Theory]
        [InlineData(1700)]
        [InlineData(1900)]
        [InlineData(2100)]
        public void YearDivisibleBy100AndNot400IsNotLeapYear(int year)
        {
            Assert.False(Calculator.IsLeapYear(year));
        }

        [Theory]
        [InlineData(1600)]
        [InlineData(2000)]
        [InlineData(2400)]
        public void YearDivisibleBy100And400IsLeapYear(int year)
        {
            Assert.True(Calculator.IsLeapYear(year));
        }


    }
}
