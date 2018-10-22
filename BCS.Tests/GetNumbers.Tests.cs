using System.Linq;
using Xunit;

using BCS.App.Services;

namespace BCS.Tests
{
    public class NumbersTests
    {
        [Fact]
        public void GetNumbersWithOutput_Should_Return_100_Items()
        {
            var numbersWithOutput = GetNumbers.GetNumbersWithOutput();

            Assert.True(numbersWithOutput.Count == 100);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        [InlineData(99)]
        public void GetNumbersWithOutput_Should_Include_Divisible_By_3_In_Output_For_N(int n)
        {
            var numbersWithOutput = GetNumbers.GetNumbersWithOutput();

            var outputAtN = numbersWithOutput.First(x => x.Number == n).Output;

            Assert.Contains("multiple of 3", outputAtN);
        }

        [Fact]
        public void GetNumbersWithOutput_Should_Include_Divisible_By_3_In_Output_For_Every_Number_Divisible_By_3()
        {
            var numbersWithOutput = GetNumbers.GetNumbersWithOutput();

            foreach (var numberWithOutput in numbersWithOutput)
            {
                if (numberWithOutput.Number % 3 == 0)
                {
                    Assert.Contains("multiple of 3", numberWithOutput.Output);
                }
            }
        }

        [Theory]
        [InlineData(1)]
        [InlineData(7)]
        [InlineData(26)]
        [InlineData(47)]
        [InlineData(98)]
        public void GetNumbersWithOutput_Should_Not_Include_Divisible_By_3_In_Output_For_N(int n)
        {
            var numbersWithOutput = GetNumbers.GetNumbersWithOutput();

            var outputAtN = numbersWithOutput.First(x => x.Number == n).Output;

            Assert.DoesNotContain("multiple of 3", outputAtN);
        }

        [Fact]
        public void GetNumbersWithOutput_Should_Not_Include_Divisible_By_3_In_Output_For_Numbers_Which_Are_Not_Divisible_By_3()
        {
            var numbersWithOutput = GetNumbers.GetNumbersWithOutput();

            foreach (var numberWithOutput in numbersWithOutput)
            {
                if (numberWithOutput.Number % 3 != 0)
                {
                    Assert.DoesNotContain("multiple of 3", numberWithOutput.Output);
                }
            }
        }

        [Theory]
        [InlineData(6)]
        [InlineData(16)]
        [InlineData(46)]
        [InlineData(76)]
        [InlineData(96)]
        public void GetNumbersWithOutput_Should_Include_Ends_In_6_In_Output_For_N(int n)
        {
            var numbersWithOutput = GetNumbers.GetNumbersWithOutput();

            var outputAtN = numbersWithOutput.First(x => x.Number == n).Output;

            Assert.Contains("ends in 6", outputAtN);
        }

        [Fact]
        public void GetNumbersWithOutput_Should_Include_Ends_In_6_In_Output_For_Every_Number_That_Ends_With_The_Digit_6()
        {
            var numbersWithOutput = GetNumbers.GetNumbersWithOutput();

            foreach (var numberWithOutput in numbersWithOutput)
            {
                if (numberWithOutput.Number % 10 == 6)
                {
                    Assert.Contains("ends in 6", numberWithOutput.Output);
                }
            }
        }

        [Theory]
        [InlineData(5)]
        [InlineData(11)]
        [InlineData(48)]
        [InlineData(73)]
        [InlineData(90)]
        public void GetNumbersWithOutput_Should_Not_Include_Ends_In_6_In_Output_For_N(int n)
        {
            var numbersWithOutput = GetNumbers.GetNumbersWithOutput();

            var outputAtN = numbersWithOutput.First(x => x.Number == n).Output;

            Assert.DoesNotContain("ends in 6", outputAtN);
        }

        [Fact]
        public void GetNumbersWithOutput_Should_Not_Include_Ends_In_6_In_Output_For_Every_Number_That_Ends_With_A_Digit_Other_Than_6()
        {
            var numbersWithOutput = GetNumbers.GetNumbersWithOutput();

            foreach (var numberWithOutput in numbersWithOutput)
            {
                if (numberWithOutput.Number % 10 != 6)
                {
                    Assert.DoesNotContain("ends in 6", numberWithOutput.Output);
                }
            }
        }

        [Theory]
        [InlineData(6)]
        [InlineData(36)]
        [InlineData(66)]
        [InlineData(96)]
        public void GetNumbersWithOutput_Should_Include_Divisible_By_3_And_Ends_In_6_In_Output_For_N(int n)
        {
            var numbersWithOutput = GetNumbers.GetNumbersWithOutput();

            var outputAtN = numbersWithOutput.First(x => x.Number == n).Output;

            Assert.Contains("multiple of 3, ends in 6", outputAtN);
        }

        [Fact]
        public void GetNumbersWithOutput_Should_Include_Divisible_By_3_And_Ends_In_6_In_Output_For_Every_Number_That_Is_Divisible_By_3_And_Ends_With_The_Digit_6()
        {
            var numbersWithOutput = GetNumbers.GetNumbersWithOutput();

            foreach (var numberWithOutput in numbersWithOutput)
            {
                if (numberWithOutput.Number % 3 == 0 && numberWithOutput.Number % 10 == 6)
                {
                    Assert.Contains("multiple of 3, ends in 6", numberWithOutput.Output);
                }
            }
        }
    }
}
