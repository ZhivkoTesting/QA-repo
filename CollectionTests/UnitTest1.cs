using Collections;

namespace CollectionTests
{
    public class CollectionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var collection = new Collection<int>();
            Assert.AreEqual(collection.ToString(), "[]");
        }
    }
}