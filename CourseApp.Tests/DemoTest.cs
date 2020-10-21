using System;
using System.Collections.Generic;
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

        [Fact]
        public void TestMyFunctionZeros()
        {
            var res = Program.Сalculation(0.0, 0.0, 0.0).Count;
            Assert.Equal(double.NaN, res);
        }

        [Fact]
        public void TestNullB()
        {
            List<double> e = new List<double>();
            var res = Program.Сalculation2(e).Count;
            Assert.Equal(double.NaN, res);
        }

        [Fact]
        public void TestTrueA()
        {
            var res = Program.Сalculation(0.26, 0.66, 0.08);
            List<double> result = new List<double>() { 0.834215045903759, 0.75429795697566, 0.688425423366074, 0.652365112574963, 0.663883187692699, 0.751251000538057 };
            Assert.Equal(result, res, 3);
        }

        [Fact]
        public void TestTrueB()
        {
            List<double> input = new List<double>() { 0.1, 0.35, 0.4, 0.55, 0.6 };
            var res = Program.Сalculation2(input);
            List<double> result = new List<double>() { 0.970885488727385, 0.744968715506544, 0.702712806929317, 0.65257962383342, 0.677063603240845 };
            Assert.Equal(res, result, 3);
        }
    }
}