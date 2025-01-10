using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics.Test
{
    public  class AdvMathTest
    {
        
        [Theory]
        [InlineData(5.0, 10.0, 50.0)]  // 5 * 10 = 50
        [InlineData(7.0, 3.0, 21.0)]   // 7 * 3 = 21
        public void TestCalcArea(double height, double width, double expectedArea)
        {
            var math = new AdvMath();
            var result = math.CalcArea(height, width);
            Assert.Equal(expectedArea, result);
        }


        [Theory]
        [InlineData(3.0, 9.0)]   // 3 * 3 = 9
        [InlineData(5.0, 25.0)]  // 5 * 5 = 25
        public void TestSquared(double value, double expectedSquared)
        {
            var math = new AdvMath();
            var result = math.Squared(value);
            Assert.Equal(expectedSquared, result);
        }

        [Fact]
        public void TestCalcAverage()
        {
            var math = new AdvMath();
            var values = new List<double> { 10.0, 20.0, 30.0, 40.0 };
            var result = math.CalcAverage(values);
            Assert.Equal(25.0, result);  // (10 + 20 + 30 + 40) / 4 = 25
        }

        [Theory]
        [InlineData(3.0, 4.0, 5.0)]   
        public void TestCalcHypotenuse(double a, double b, double expectedHypotenuse)
        {
            var math = new AdvMath();
            var result = math.CalcHypotenuse(a, b);
            Assert.Equal(expectedHypotenuse, result);
        }
    }
}
