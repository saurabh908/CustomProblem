using NUnit.Framework;

namespace Tests
{
    public class SKUTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CheckSKU()
        {
            int countSKU = SKU.GetSKUCount();
            Assert.AreEqual(26, countSKU);
        }
    }
}