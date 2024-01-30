using FluentAssertions;

namespace FullCICDDemo.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string excpected = "Hello World!";
            string result = "Hello World!";

            result.Should().BeEquivalentTo(excpected);
        }

        [Fact]
        public void Test2()
        {
            string excpected = "Hello World!";
            string result = "Hello";

            result.Should().NotBeEquivalentTo(excpected);
        }
    }
}