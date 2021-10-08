
using Xunit;
using Starter;

namespace Test
{
    public class numberOfProvincesTest
    {
        int [,] m =  { { 1, 1, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0 }, { 0, 0, 1, 1, 1, 0 }, { 0, 0, 1, 1, 0, 0 }, { 0, 0, 1, 0, 1, 0 }, { 0, 0, 0, 0, 0, 1 } };
        int[,] small = { { 1,1,0}, { 1, 1, 0 }, { 0,0,1}  };

        public numberOfProvincesTest()
        {
        }


        [Fact]
        public void ShouldMatchNumberOfProvinceSmall()
        {
            Assert.Equal(2, NumberOfProvinces.GetResult(small));
        }

        [Fact]
        public void ShouldMatchNumberOfProvince()
        {
            Assert.Equal(3, NumberOfProvinces.GetResult(m));
        }
    }
}
