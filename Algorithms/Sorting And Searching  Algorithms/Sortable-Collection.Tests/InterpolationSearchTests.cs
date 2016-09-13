namespace Sortable_Collection.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    [TestClass]
    public class InterpolationSearchTests
    {
        private static readonly Random Random = new Random();

        [TestMethod]
        public void TestWithEmptyCollectionShouldReturnMissingElement()
        {
            var collection = new SortableCollection<int>();

            var result = collection.InterpolationSearch(collection, 0);
            var expected = Array.BinarySearch(collection.ToArray(), 0);

            Assert.AreEqual(expected, result, "No elements are present in an empty collection; method should return -1.");
        }

        [TestMethod]
        public void TestWithMissingElement()
        {
            var collection = new SortableCollection<int>(-1, 1, 5, 12, 50);

            var result = collection.InterpolationSearch(collection, 0);
            var expected = -1;

            Assert.AreEqual(expected, result, "Missing element should return -1.");
        }

        [TestMethod]
        public void TestWithItemAtMidpoint()
        {
            var collection = new SortableCollection<int>(1, 2, 3, 4, 5);

            var result = collection.InterpolationSearch(collection, 3);
            var expected = Array.BinarySearch(collection.ToArray(), 3);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestWithItemToTheLeftOfMidpoint()
        {
            var collection = new SortableCollection<int>(1, 2, 3, 4, 5);

            var result = collection.InterpolationSearch(collection, 2);
            var expected = Array.BinarySearch(collection.ToArray(), 2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestWithItemToTheRightOfMidpoint()
        {
            var collection = new SortableCollection<int>(1, 2, 3, 4, 5);

            var result = collection.InterpolationSearch(collection, 4);
            var expected = Array.BinarySearch(collection.ToArray(), 4);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestWithRepeatingItemShouldReturnFirstDiscoveredIndex()
        {
            var collection = new SortableCollection<int>(0, 3, 3, 3, 3, 7, 7, 7, 7, 7, 7);
            var result = collection.InterpolationSearch(collection, 3);

            Assert.AreEqual(2, result);
        }
    }
}

