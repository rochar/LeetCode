using FluentAssertions;
using LeetCodeLibrary.Easy;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class _1_TwoSumTests
    {
        [Fact]
        public void WhenOneBitCharacterShouldBeTrue()
        {
            var sut = new _1_TwoSum();
            var result = sut.TwoSum(new[] {2, 7, 11, 15},9);

            result.Should().BeEquivalentTo(new[] {0, 1});
        }
    }
}