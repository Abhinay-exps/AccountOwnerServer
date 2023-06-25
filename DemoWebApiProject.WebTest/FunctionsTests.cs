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
            Assert.True(3 == functions.Add(1, 2),"returned right result");
        }
    }
}