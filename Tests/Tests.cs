using NUnit.Framework;

namespace Competition.Tests
{
    internal class Tests : Global.Base
    {
        [Test]
        public void WhenIEnterListing()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }
    }
}