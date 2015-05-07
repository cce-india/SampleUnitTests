using System;
using Shouldly;
using Xunit;

namespace SampleUnitTests
{
    public class Class1
    {

        [Fact]
        public void AlwaysTrueTest()
        {
            Assert.True(true);
        }
        [Fact]
        public void AlwaysFalseTest()
        {
            Assert.False(Add(50, 50) == 100 ? true : false);
        }
        [Fact]
        public void FailedTest()
        {
            Assert.Equal(5, Add(3, 2));
        }

        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(9)]
        [InlineData(7)]
        [InlineData(48)]
        public void TestTheary(int value)
        {
            Assert.True(IsOddNumber(value));
        }

        public bool IsOddNumber(int value)
        {
            return value % 2 == 1;
        }

        [Fact]
        public void ThrowExceptionTest()
        {
            int[] testIntArray = new int[4]{1,2,3,4};
                Assert.Throws<System.IndexOutOfRangeException>(
                delegate
                {
                    testIntArray[4] = 90;
                });
        }

        
        [Fact(Skip = "To test Skip test")]
        public void SkipTest()
        {
            Assert.Equal(5, Add(2,2));
        }
        [Fact]
        public void InRangeTest()
        {
            Assert.InRange(50,50,55);
        }

        [Fact]
        public void ContainsTest()
        {
            Assert.Contains("ns",new String[]{"ns","mg","ap"});
            Assert.DoesNotContain("gj", new String[] { "ns", "mg", "ap" });
            Assert.Contains("NS", new String[] { "ns", "mg", "ap" });
        }

        [Fact]
        public void ShouldBeTest()
        {
            int testInt = 2;
            testInt.ShouldBe(2);
            "NS".ShouldBeOneOf(new String[] { "ns", "mg", "ap" });
            "mg".ShouldBeOneOf(new String[] { "ns", "mg", "ap" });
            testInt.ShouldBeGreaterThan(1);
        }

        
    }

}
