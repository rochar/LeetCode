using FluentAssertions;
using LeetCodeLibrary.Easy;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class _717_IsOneBitCharacterTests
    {
        [Fact]
        public void WhenOneBitCharacterShouldBeTrue()
        {
            var sut = new _717_IsOneBitCharacter();
            bool result = sut.IsOneBitCharacter(new[] {1, 0, 0});

            result.Should().BeTrue();
        }

        [Fact]
        public void WhenTwoBitCharactersShouldBeFalse()
        {
            var sut = new _717_IsOneBitCharacter();
            bool result = sut.IsOneBitCharacter(new[] { 1,1,1, 0});

            result.Should().BeFalse();
        }
    }
}