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
        public void GetCombineTest() 
        {
            String result = Sample.Combine("aaa", "bbb", "ccc");
            Assert.Equal("aaabbbccc", result);
        
        }
    }
}