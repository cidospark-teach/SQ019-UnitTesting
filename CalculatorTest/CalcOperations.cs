using ConsoleApp4;

namespace CalculatorTest
{
    public class CalcOperations
    {
        //[Fact]
        //public void TrueIsTrue()
        //{
        //    Assert.True(false);
        //}

        // Things to consider when testing
        // - Test for actual values
        // - Test for Invalid Values
        // - Test for edge cases


        [Fact(Skip ="This test case is not ready!")]
        public void SumIsValid()
        {
            // Arrange
            var calc = new CalcOperation();
            var a = 1;
            var b = 2;
            //var x = 5;
            //var y = 5;
            var expected1 = 3;
            //var expected2 = 10;

            // Act
            var actual1 = calc.Sum(a, b);
            //var actual2 = calc.Sum(x, y);

            // Assert
            Assert.Equal(expected1, actual1);
            //Assert.Equal(expected2, actual2);
        }

        // Inline method
        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(5, 5, 1)]
        [InlineData(15, 3, 5)]
        [InlineData(21, 7, 3)]
        public void DividIsValid(double a, double b, double expected)
        {
            // Arrange
            var calc = new CalcOperation();

            // Act
            var actual = calc.Divide(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }


        // embeded method
        public static IEnumerable<object[]> memberData =
            new List<object[]> {
                                    new object[] {2, 0},
                                    new object[] {5, 0},
                                    new object[] {15, 0}
                                };

        // External method
        [Theory]
        [MemberData(nameof(memberData))]
        public void DivideByZeroShouldThrow(double x, double y)
        {
            // Arrange
            var calc = new CalcOperation();

            // Assert
            Assert.Throws<ArithmeticException>(() => calc.Divide(x, y));
        }


        [Theory]
        [ClassData(typeof(TestData))]
        public void MultiplicationIsValid(double a, double b, double expected)
        {
            // Arrange
            var calc = new CalcOperation();

            // Act
            var actual = calc.Multiply(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SimpleTest()
        {
            // Arrange
            var calc = new CalcOperation();
            var firstName = "Peace";
            var secondName = "Osamuyi";
            var expected = "Peace, OSAMUYI";

            // Act
            var actual = calc.GetFullName(firstName, secondName);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}