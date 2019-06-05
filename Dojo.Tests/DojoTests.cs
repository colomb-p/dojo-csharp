using NUnit.Framework;

namespace Dojo.Tests
{
    [TestFixture]
    public class DojoTests
    {
        [Test]
        public void Add_ZeroAndZero_ShouldBeZero()
        {
            Assert.AreEqual(0, Dojo.Add(0, 0));
        }
    }
}