using DemoWebApiProject.Utilities;
using Xunit;

namespace DemoWebApiProject.WebTest
{
    public class FunctionsTests
    {
        [Fact]
        public void CheckAddFunction()
        {
            var functions = new Functions();
            Assert.True(4 == functions.Add(2, 2),"returned right result");
        }
    }
}
