using PlayWithJenkins;
using System;
using Xunit;

namespace MyMathTests
{
    public class MyMathTests
    {
        [Fact]
        public void SqrTest()
        {
            double x = 3;
            double result = MyMath.Sqr(x);
            Assert.Equal(9, result);
        }
    }
}
