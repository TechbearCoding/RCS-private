using Day26;

namespace Day26Test
{
    public class SampleTest
    {
        [Fact]
        public void GetSumTest()
        {
            int a = 3;
            int b = 4;
            
            int expected = a + b;
            int result = Sample.GetSum(a, b);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetCombineTest_complete() 
        {
            String result = Sample.Combine("aaa", "bbb", "ccc");
            Assert.Equal("aaabbbccc", result);
        }

        [Fact]
        public void GetCombineTest_error()
        {
            String result = Sample.Combine("aaa", "", "ccc");
            Assert.Equal("error", result);

            result = Sample.Combine("", "bbb", "ccc");
            Assert.Equal("error", result);

            result = Sample.Combine("aaa", "bbb", "");
            Assert.Equal("error", result);

            result = Sample.Combine("", "", "");
            Assert.Equal("error", result);
        }

    }
}