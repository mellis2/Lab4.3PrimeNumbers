using System;
using Xunit;

namespace Lab4._3XUnit
{
    public class UnitTest1
    {
        [Theory]
        public void Test1()
        {
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 5)]
        [InlineData(4, 7)]
        [InlineData(5, 11)]
        [InlineData(6, 13)]
        [InlineData(7, 17)]
        [InlineData(8, 19)]
        [InlineData(9, 23)]
        [InlineData(10, 29)]
        [InlineData(11, 31)]
        [InlineData(12, 37)]
        [InlineData(13, 41)]
        [InlineData(14, 43)]
        [InlineData(15, 47)]
        [InlineData(16, 53)]
        [InlineData(17, 59)]
        [InlineData(18, 61)]
        [InlineData(19, 67)]
        [InlineData(20, 71)]
        }
    }
}
