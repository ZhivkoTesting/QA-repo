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
        public void showEmptyCollection()
        {
            var collection = new Collection<int>();
            Assert.AreEqual(collection.ToString(), "[]");
        }

        [Test]
        public void initialCount()
        {
            var collection = new Collection<int>();
            Assert.AreEqual(collection.Count, 0);
        }
        [Test]
        public void initialCapacity()
        {
            var collection = new Collection<int>();
            Assert.That(collection.Capacity, Is.EqualTo(16));
        }
        [Test]
        public void addFirstItem()
        {
            var collection = new Collection<int>();
            collection.Add(5);
            Assert.That(collection.Capacity, Is.EqualTo(16));
            Assert.That("[5]", Is.EqualTo(collection.ToString()));
        }

        //  

        [Test]
        public void addMultyItems()
        {
            var collection = new Collection<string>("Cat", "Dog");
            collection.Add("Rabit");
            Assert.That("[Cat, Dog, Rabit]", Is.EqualTo(collection.ToString()));
        }
        [Test]
        public void removeAtPosition()
        {
            var collection = new Collection<string>("Rabbit", "Snake", "Frog");
            collection.RemoveAt(1);
            Assert.That("[Rabbit, Frog]", Is.EqualTo(collection.ToString()));
        }

    }
}