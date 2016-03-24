namespace CustomLinkedList.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DynamicListTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DynamicListSetter_TestWithInvalidIndex_ShouldTrowArgumentOutOfRangeException()
        {
            var testList = new DynamicList<int>();

            var indexGreater = testList.Count + 3;
            var indexLower = -2;

            Assert.IsNull(
                testList[indexGreater],
                "Number of dynamic list positions cannot be more than its count.");

            Assert.IsNull(
                testList[indexLower],
                "Number of dynamic list positions cannot be < 0");
        }

        [TestMethod]
        public void Add_Empty_HasContaintAfter()
        {
            var testList = new DynamicList<string>();
            string person1 = "Alex";

            testList.Add(person1);

            Assert.IsTrue(
                testList.Count == 1,
                "Impossible to create a head and a tail with one item added to empty list.");
        }

        [TestMethod]
        public void Add_NonEmpty_HasContaintAfter()
        {
            var testList = new DynamicList<string>();
            string person1 = "Alex";
            string person2 = "Beti";
            string person3 = "Eti";

            testList.Add(person1);
            testList.Add(person2);
            testList.Add(person3);

            Assert.IsTrue(
                testList[2] == "Eti",
                "Last added item does not append after tail.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveAt_TestWithInvalidIndex_ShouldTrowArgumentOutOfRangeException()
        {
            var testList = new DynamicList<string>();
            var indexGreater = testList.Count + 3;
            var indexLower = -2;

            testList.RemoveAt(indexGreater);
            testList.RemoveAt(indexLower);
        }

        [TestMethod]
        public void RemoveAt_NotEmptyList_ShouldRemoveElement()
        {
            var testList = new DynamicList<int>();

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.RemoveAt(2);

            Assert.IsTrue(
                testList[1] == 2 && testList[2] == 4,
                "Element at this position is not removed from the list of nodes.");
        }

        [TestMethod]
        public void RemoveAt_NotEmptyList_ShouldReturnRemovedElement()
        {
            var testList = new DynamicList<int>();

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            var removedElement = testList.RemoveAt(3);

            Assert.AreEqual(4, removedElement, "Removed element is not returned.");
        }

        [TestMethod]
        public void Remove_NotEmptyList_ShouldRemoveElement()
        {
            var testList = new DynamicList<object>();
            DateTime date = new DateTime();
            date = DateTime.Today;
            bool isRainy = true;

            testList.Add(4);
            testList.Add("house");
            testList.Add(4.18);
            testList.Add(date);
            testList.Add(isRainy);
            testList.Remove(date);

            Assert.IsTrue(
                !testList.Contains(date),
                "Element is not removed from the list of nodes.");
        }

        [TestMethod]
        public void Remove_NotEmptyList_ShouldReturnAppropriateResult()
        {
            var testList = new DynamicList<object>();

            testList.Add(4);
            testList.Add("house");
            testList.Add(4.18);
            testList.Add(Math.Cos(90));
            testList.Add(Math.Pow(3.56, 8.45));
            var resultIndex = testList.Remove("house");

            Assert.AreEqual(1, resultIndex, "Index of removed element is not returned.");
        }

        [TestMethod]
        public void Remove_RemoveUnexistingElement_ShouldNotRemoveAnyElement()
        {
            var testList = new DynamicList<double>();

            for (double i = 0; i < 1.1; i = i + 0.1)
            {
                testList.Add(i);
            }

            var resultTestList = testList;
            resultTestList.Remove(5.5);

            Assert.AreEqual(testList.Count, resultTestList.Count, "Unspecified item is removed.");
        }

        [TestMethod]
        public void Remove_RemoveUnexistingElement_ShouldReturnAppropriateResult()
        {
            var testList = new DynamicList<double>();

            var returnedElement = testList.Remove(5);

            Assert.AreEqual(-1, returnedElement, "Index of unremoved element must be -1.");
        }

        [TestMethod]
        public void IndexOf_ExistingElement_ReturnIndexOfSpecifiedElement()
        {
            var testList = new DynamicList<double>();

            testList.Add(1);
            testList.Add(0);
            testList.Add(-1.1);
            testList.Add(-2.3);
            testList.Add(4);
            var resultIndex = testList.IndexOf(-2.3);

            Assert.AreEqual(3, resultIndex, "Not the index of specified element is returned");
        }

        [TestMethod]
        public void IndexOf_NonExistingElement_ShouldReturnAppropriateResult()
        {
            var testList = new DynamicList<int>();

            testList.Add(1);
            testList.Add(0);
            testList.Add(3);
            testList.Add(7);
            testList.Add(-4);
            var resultIndex = testList.IndexOf(2);

            Assert.AreEqual(-1, resultIndex, "Returned index must be -1");
        }

        [TestMethod]
        public void Contains_ExistingElement_ShouldReturnTrue()
        {
            var testList = new DynamicList<int>();

            testList.Add(-3);
            testList.Add(-2);
            testList.Add(-1);
            var result = testList.Contains(-3);

            Assert.IsTrue(result, "Result must be true.");
        }

        [TestMethod]
        public void Contains_UnexistingElement_ShouldReturnFalse()
        {
            var testList = new DynamicList<int>();

            testList.Add(-3);
            testList.Add(-2);
            testList.Add(-1);
            var result = testList.Contains(6);

            Assert.IsFalse(result, "Result must be false.");
        }
    }
}
