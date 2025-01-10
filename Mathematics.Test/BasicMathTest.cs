using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Mathematics.Test
{
     public class BasicMathTest
    {
        //[Fact]
        [Theory]
        [InlineData(5,3,8)]
        [InlineData(10,3,13)]

        public void TestAddNumbers(int num1, int num2, int expectedResult) 
        { 
         var math = new BasicMath();
            var result = math.AddNumbers(num1, num2);
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void TestSubtractNumbers()
        {
            var math = new BasicMath();
            var result = math.SubtractNumbers(10, 3);
            Assert.True(result == 7);
        }
        [Fact]
        public void TestMultiplyNumbers()
        {
            var math = new BasicMath();
            var result = math.MultiplyNumbers(5, 6);
            Assert.True(result == 30);
        }
        [Fact]
        public void TestDivideNumbers()
        {
            var math = new BasicMath();
            var result = math.DivideNumbers(50, 5);
            Assert.True(result == 10);
        }

    }
}
