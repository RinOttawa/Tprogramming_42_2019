using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Theory]
        [InlineData(0, 0, 0, 0)]
        [InlineData(0, 2, 1, 2)]
        [InlineData(1, 2, 1, 3)]
        public void TestFunctionCalculationVal(double a, double b, double x, double exp)
        {
            var res = Program.MyFunction(a, b, x);
            Assert.Equal(exp, res, 3);
        }
    }
}
