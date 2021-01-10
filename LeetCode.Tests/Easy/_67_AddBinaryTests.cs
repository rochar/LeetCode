using FluentAssertions;
using LeetCodeLibrary.Easy;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class _67_AddBinaryTests
    {
        [Theory]
        [InlineData("11", "1", "100")]
        [InlineData("1010", "1011", "10101")]
        [InlineData("101011111", "10111", "101110110")]
        [InlineData("11", "11010010", "11010101")]
        [InlineData("0", "0", "0")]
        public void WhenAddShould(string a, string b, string expected)
        {
            var sut = new _67_AddBinary();
            var result = sut.AddBinary(a,b);

            result.Should().Be(expected);
        }
    }
}