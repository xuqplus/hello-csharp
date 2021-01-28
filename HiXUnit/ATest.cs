using System;
using Xunit;
using Xunit.Abstractions;

namespace HiXUnit
{
    public class ATest
    {
        private ITestOutputHelper OutputHelper { get; }

        public ATest(ITestOutputHelper outputHelper)
        {
            OutputHelper = outputHelper;
        }

        [Fact]
        public void AMethod()
        {
            Console.WriteLine("this is xunit - Console");
            OutputHelper.WriteLine("this is xunit - OutputHelper");

            Assert.True(true);
            //Assert.True(false);
        }
    }
}
